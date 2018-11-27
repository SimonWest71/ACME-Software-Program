using System;
using System.Net;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace Movie_InterfaceAPI
{
    public partial class Main : Form
    {
        public ImdbEntity_S Entity_S = new ImdbEntity_S();
        public ImdbEntity_M Entity_M = new ImdbEntity_M();
        public SeenListUC SeenListUserControl;
        public WishListUC WishListUserControl;

        public Main()
        {
            InitializeComponent();

			//if (Properties.Settings.Default.SeenList == null)
			//	Properties.Settings.Default.SeenList = new System.Collections.Generic.List<string>();
			//if (Properties.Settings.Default.WishList == null)
			//	Properties.Settings.Default.WishList = new System.Collections.Generic.List<string>();

			//Properties.Settings.Default.Save();
        }
        private void SearchTb_Enter(object sender, EventArgs e)
        {
            if (SearchTb.Text == "Search for movie title...")
                SearchTb.Text = string.Empty;
        }
        private void SearchTb_Leave(object sender, EventArgs e)
        {
            if (SearchTb.Text == string.Empty)
                SearchTb.Text = "Search for movie title...";
        }
        public bool TitleInWishList(string title)
        {
            if (Properties.Settings.Default.WishList.Contains(title))
                return true;
            return false;
        }
        public bool TitleInSeenList(string title)
        {
            if (Properties.Settings.Default.SeenList.Contains(title))
                return true;
            return false;
        }
        public int TitlesWished()
        {
            return Properties.Settings.Default.WishList.Count;
        }
        public void UpdateResultResult()
        {
            this.MoviesFLP.Controls.Clear();

            string url = string.Empty;

            if (MultipleCb.Checked)
            {
                url = OMDB.multipleAddress + SearchTb.Text.Trim() + "&apikey=" + OMDB.api;
            }
            else
            {
                url = OMDB.singleAddress + SearchTb.Text.Trim() + "&apikey=" + OMDB.api;
            }

            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString(url);

                JavaScriptSerializer oJS = new JavaScriptSerializer();

                if (MultipleCb.Checked)
                {
                    Entity_M = oJS.Deserialize<ImdbEntity_M>(json);
                    var movies = oJS.Serialize(Entity_M);

                    if (Entity_M.Response == "True")
                    {
                        foreach (var movie in Entity_M.Search)
                        {
                            MovieUC MovieUserControl = new MovieUC(movie.Title, movie.Year, movie.Poster, movie.Type, TitleInWishList(movie.Title), TitleInSeenList(movie.Title), this);
                            MoviesFLP.Controls.Add(MovieUserControl);
                        }
                    }
                    else
                    {
                        MessageBox.Show("There was an error requesting movie data", "Error");
                    }
                }
                else
                {
                    Entity_S = oJS.Deserialize<ImdbEntity_S>(json);

                    if (Entity_S.Response == "True")
                    {
                        MovieUC MovieUserControl = new MovieUC(Entity_S.Title, Entity_S.Year, Entity_S.Poster, Entity_S.Type, TitleInWishList(Entity_S.Title), TitleInSeenList(Entity_S.Title), this);
                        MoviesFLP.Controls.Add(MovieUserControl);
                    }
                    else
                    {
                        MessageBox.Show("There was an error requesting movie data", "Error");
                    }
                }
                SeenListUserControl = new SeenListUC(NumberOfMoviesSeenInSearchCategory(SearchTb.Text), this);
                MoviesFLP.Controls.Add(SeenListUserControl);
                WishListUserControl = new WishListUC(Properties.Settings.Default.WishList.Count, this);
                MoviesFLP.Controls.Add(WishListUserControl);
            }
        }
        public int NumberOfMoviesSeenInSearchCategory(string title)
        {
            int movieMatched = 0;

            for (int i = 0; i < Properties.Settings.Default.SeenList.Count; i++)
            {
                if (Properties.Settings.Default.SeenList[i].Contains(title))
                {
                    movieMatched++;
                }
            }
            return movieMatched;
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            UpdateResultResult();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            SeenListUserControl = new SeenListUC(NumberOfMoviesSeenInSearchCategory(SearchTb.Text), this);
            MoviesFLP.Controls.Add(SeenListUserControl);
            WishListUserControl = new WishListUC(Properties.Settings.Default.WishList.Count, this);
            MoviesFLP.Controls.Add(WishListUserControl);
        }
    }
}
