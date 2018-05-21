using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace Lan_Messenger
{
    public partial class FormMusicPlayer : Form
    {
        public string siteURL = "http://mp3.zing.vn";
        string[] listSongLink;
        string[] listSinger;
        string LinkSong = "";
        string downloadLink = "";
        string savePath;

        public FormMusicPlayer()
        {
            InitializeComponent();
            InitializeListView();

            // Gửi nhạc cho bạn bè
            foreach (object o in Global.contactList)
            {
                cbbListContact.Items.Add(Global.server.GetfullName(((LanMessengerControls.LanMessengerContact)o).Contact.ToString()) + " (" + ((LanMessengerControls.LanMessengerContact)o).Contact.ToString() + ")");
            }
        }

        FormMessage fm;
        public FormMusicPlayer(FormMessage form)
        {
            InitializeComponent();
            InitializeListView();

            // Gửi nhạc cho bạn bè
            foreach (object o in Global.contactList)
            {
                cbbListContact.Items.Add(Global.server.GetfullName(((LanMessengerControls.LanMessengerContact)o).Contact.ToString()) + " (" + ((LanMessengerControls.LanMessengerContact)o).Contact.ToString() + ")");
            }

            // Tuyền link bài hát nếu có bạn bè gửi tặng nhạc
            fm = new FormMessage();
            fm = form;
            LinkSong = fm.LinkSongSend;
        }

        public void InitializeListView()
        {
            ColumnHeader header1 = this.lvListSong.Columns.Add("Tên bài hát", 35 * Convert.ToInt32(lvListSong.Font.SizeInPoints), HorizontalAlignment.Center);
            ColumnHeader header2 = this.lvListSong.Columns.Add("Trình bày", 30 * Convert.ToInt32(lvListSong.Font.SizeInPoints), HorizontalAlignment.Center);
        }

        private void FormMusicPlayer_Load(object sender, EventArgs e)
        {
            if (LinkSong != "")
            {
                downloadLink = PlayUrl(LinkSong);
                axWindowsMediaPlayer1.URL = downloadLink;
            }
            if (downloadLink !="")
                btnDownload.Enabled = true;
        }

        // Sự kiện khi ấn nút TÌM
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                lvListSong.Clear(); // Xóa các kết quả cũ đi.
                InitializeListView();

                string SearchUrl = "http://mp3.zing.vn/tim-kiem/bai-hat.html?search_type=bai-hat&search_query=" + ReplaceSpacetoPlus(txtSearch.Text);
                string ContentOfSearch = GetWebContent(SearchUrl);
                listSongLink = GetlistSongLink(ContentOfSearch);

                string[] ListSong_Singer = GetlistSong_Singer(ContentOfSearch);
                for (int i = 0; i < listSongLink.Length; i++)
                {
                    int split = ListSong_Singer[i].IndexOf("-");
                    AddItemToListView(ListSong_Singer[i].Substring(0, split), ListSong_Singer[i].Substring(split + 1, ListSong_Singer[i].Length - split - 1)); // AddItemToListView("Ten bai hat", "Ca Sy");
                }
            }
            else
                MessageBox.Show("Vui lòng nhập tên bài hát cần tìm", "Lỗi");
        }

        // Sự kiện khi nhấn Enter để tìm
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSearch.Text != "")
                {
                    lvListSong.Clear(); // Xóa các kết quả cũ đi.
                    InitializeListView();

                    string SearchUrl = "http://mp3.zing.vn/tim-kiem/bai-hat.html?search_type=bai-hat&search_query=" + ReplaceSpacetoPlus(txtSearch.Text);
                    string ContentOfSearch = GetWebContent(SearchUrl);
                    listSongLink = GetlistSongLink(ContentOfSearch);

                    string[] ListSong_Singer = GetlistSong_Singer(ContentOfSearch);
                    for (int i = 0; i < listSongLink.Length; i++)
                    {
                        int split = ListSong_Singer[i].IndexOf("-");
                        AddItemToListView(ListSong_Singer[i].Substring(0, split), ListSong_Singer[i].Substring(split + 1, ListSong_Singer[i].Length - split - 1)); // AddItemToListView("Ten bai hat", "Ca Sy");
                    }
                }
                else
                    MessageBox.Show("Vui lòng nhập tên bài hát cần tìm", "Lỗi");
            }            
        }

        // Thêm 1 bài nhạc vào listview
        private void AddItemToListView(string Song, string Singer)
        {
            int n = this.lvListSong.Items.Count;
            this.lvListSong.Items.Add(Song);
            this.lvListSong.Items[n].SubItems.Add(Singer);
        }

        // Sự kiện khi chọn 1 bài nhạc trong list để play.
        private void lvListSong_SelectedChanged(Object sender, EventArgs e)
        {
            int index = 0;
            if (this.lvListSong.SelectedItems.Count > 0)
                index = this.lvListSong.SelectedIndices[0]; // Lấy stt của 1 Items trên lvListSong
            downloadLink = PlayUrl(listSongLink[index]);
            axWindowsMediaPlayer1.URL = downloadLink;
            btnDownload.Enabled = true;
        }

        // Xuất ra FULL LINK để play.
        private string PlayUrl(string LinkSong)
        {
            string content = GetWebContent(LinkSong);
            string url = ReadXML(GetWebContent(GetXMLLink(content)));
            //string subUrl = CreateMD5SubLink(); // Zing đã ko dùng mã hóa này nữa

            lblSongName.Text = GetXMLSongName(GetWebContent(GetXMLLink(content)));
            lblSinger.Text = GetXMLSingerName(GetWebContent(GetXMLLink(content)));
            //return url + subUrl;
            return url;
        }

        // Hàm lấy nội dung HTML của một trang web
        public string GetWebContent(string strLink)
        {
            string strContent = "";
            try
            {
                WebRequest objWebRequest = WebRequest.Create(strLink);
                objWebRequest.Credentials = CredentialCache.DefaultCredentials;
                WebResponse objWebResponse = objWebRequest.GetResponse();
                Stream receiveStream = objWebResponse.GetResponseStream();
                StreamReader readStream = new StreamReader(receiveStream, System.Text.Encoding.UTF8);
                strContent = readStream.ReadToEnd();
                objWebResponse.Close();
                readStream.Close();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return strContent;
        }

        // Đọc nội dung HTML để lấy danh sách link nhạc được tìm kiếm
        private string[] GetlistSongLink(string content)
        {
            int i = 0;
            int count = NumberOfSearch(content);
            string[] list;
            string pattern = "/bai-hat/+[^\"]+";
            Regex SongName = new Regex(pattern);
            MatchCollection mc = SongName.Matches(content);
            if (mc.Count > 0)
            {
                // Tính số kết quả search được trên 1 page
                if (count > 25)
                    count = 25;

                // Đổ ra mảng list
                list = new string[count];
                for (int j = 0; j < count; j++)
                {
                    list[i] = siteURL + mc[i].Value;
                    i++;
                }
            }
            else
            {
                list = new string[1];
                list[0] = "Không có kết quả nào";
            }
            return list;
        }

        // Đọc nội dung HTML để lấy danh sách tên bài hát và ca sỹ khi tìm kiếm
        private string[] GetlistSong_Singer(string content)
        {
            int i = 0;
            int count = NumberOfSearch(content);
            string[] list;
            string pattern = "<h2><a title=\"[^\"]+";
            Regex Song_Singer = new Regex(pattern);
            MatchCollection mc = Song_Singer.Matches(content);
            if (mc.Count > 0)
            {
                // Đổ ra mảng list
                list = new string[mc.Count];
                for (int j = 0; j < mc.Count; j++)
                {
                    list[i] = mc[i].Value.Substring(14, mc[i].Value.Length - 14);
                    i++;
                }
            }
            else
            {
                list = new string[1];
                list[0] = "Không có kết quả nào";
            }
            return list;
        }

        // Số lượng kết quả tìm kiếm được
        private int NumberOfSearch(string content)
        {
            string pattern = "<strong id=\"_srchRowC\">[0-9]+";
            Regex XMLSongName = new Regex(pattern);
            Match m = XMLSongName.Match(content);
            if (m.Success)
            {
                return Int32.Parse(m.Value.Substring(23, m.Value.Length - 23));
            }
            else
                return -1;
        }

        // Đọc XML để lấy tên bài hát
        private string GetXMLSongName(string content)
        {
            string pattern = "<title><!\\[CDATA\\[+[^\\]]+";
            Regex XMLSongName = new Regex(pattern);
            Match m = XMLSongName.Match(content);
            if (m.Success)
            {
                return m.Value.Substring(17, m.Value.Length - 17);
            }
            else
                return "Error";
        }

        // Đọc XML để lấy tên ca sỹ
        private string GetXMLSingerName(string content)
        {
            string pattern = "<annotation><!\\[CDATA\\[+[^\\]]+";
            Regex XMLSingerName = new Regex(pattern);
            Match m = XMLSingerName.Match(content);
            if (m.Success)
            {
                return m.Value.Substring(21, m.Value.Length - 22);
            }
            else
                return "Error";
        }

        // Đọc HTML để lấy link XML
        private string GetXMLLink(string content)
        {
            string pattern = "/xml/song-data/[^\"]+";
            Regex XMLLink = new Regex(pattern);
            MatchCollection mc = XMLLink.Matches(content);
            if (mc.Count > 0)
            {
                return "http://mp3.zing.vn" + mc[1].Value; // Có 3 link XML tìm được, sẻ lấy link thứ 2
            }
            else
            {
                return "Error-GetXMLLink";
            }
        }

        // Đọc file xml để lấy link
        private string ReadXML(string content)
        {
            string pattern = "http[^]]+";
            Regex XMLLink = new Regex(pattern);
            MatchCollection m = XMLLink.Matches(content);
            return m[0].Value; // cái đầu tiên là link để play
        }

        // Đổi thứ từ Chữ ra Số
        private int DayOfWeektoNumber(string day)
        {
            switch (day)
            {
                case "Monday":
                    return 1;
                    break;
                case "Tuesday":
                    return 2;
                    break;
                case "Wesdnesday":
                    return 3;
                    break;
                case "Thursday":
                    return 4;
                    break;
                case "Friday":
                    return 5;
                    break;
                case "Saturday":
                    return 6;
                    break;
                case "Sunday":
                    return 7;
                    break;
                default: return 0;
            }
        }

        // Cấu trúc mã hóa Link nhạc ở Zing Mp3
        private string CreateMD5SubLink()
        {
            string romeo = "3pmgniz";
            int Year = DateTime.Today.Year;
            int Month = DateTime.Today.Month;
            int Date = DayOfWeektoNumber(DateTime.Today.DayOfWeek.ToString());
            int Hour = DateTime.Now.Hour;
            string t = (Year * 3).ToString() + (Month * 3).ToString() + (Date * 3).ToString() + (Hour * 3).ToString();
            string str = romeo + t;
            string q = md5(str);

            string subURL = "?q=" + q + "&t=" + t;
            return subURL;
        }

        // Mã hóa sang MD5
        private string md5(string data)
        {
            MD5CryptoServiceProvider _md5Hasher = new MD5CryptoServiceProvider();
            byte[] bs = Encoding.UTF8.GetBytes(data);
            bs = _md5Hasher.ComputeHash(bs);
            StringBuilder s = new StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2"));
            }
            return s.ToString();
        }

        // Thay dấu Khoảng trắng bằng dấu Cộng.
        private string ReplaceSpacetoPlus(string text)
        {
            string newtext = text.Replace(" ", "+");
            return newtext;
        }

        // Chọn bạn bè để gửi nhạc
        private void cbbListContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbbListContact.SelectedItem.ToString();
            int indexChar = name.IndexOf('(');
            string contact = name.Substring(indexChar + 1, name.Length - indexChar - 2);
            if (Global.server.IsVisible(contact))
            {
                if (lblSongName.Text == "...")
                    MessageBox.Show("Vui lòng chọn bài hát trước đã!", "Lỗi!");
                else
                {
                    int index = 0;
                    if (this.lvListSong.SelectedItems.Count > 0)
                        index = this.lvListSong.SelectedIndices[0]; // Lấy stt của 1 Items trên lvListSong
                    Global.server.Send(Global.username, contact, " cmd-Music: " + Global.server.GetfullName(Global.username) + " mời bạn nghe bài nhạc " + lblSongName.Text + " trình bày bởi ca sỹ " + lblSinger.Text + "- Link: " + listSongLink[index] + "#");
                    MessageBox.Show("Lời mời đã được gửi tới " + Global.server.GetfullName(contact));
                }
            }
            else
                MessageBox.Show("Người này hiện không có online để nghe nhạc", "Lỗi!");
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            savePath = @"c:\";
            FolderBrowserDialog folderopen = new FolderBrowserDialog();
            if (folderopen.ShowDialog() == DialogResult.OK)
            {
                savePath = folderopen.SelectedPath.ToString() + "\\" + lblSongName.Text + "-" + lblSinger.Text + ".mp3";
                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webClient.DownloadFileAsync(new Uri(downloadLink), savePath);
            }
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Visible = true;
            progressBar.Value = e.ProgressPercentage;
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Đã tải bài hát về máy thành công! \nĐã lưu tại: " + savePath);
            progressBar.Visible = false;
        }
    }
}
