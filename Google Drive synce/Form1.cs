using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
namespace Google_Drive_synce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/drive-dotnet-quickstart.json
        static string[] Scopes = { DriveService.Scope.Drive };
        static string ApplicationName = "Google drive sync application";

        private void Form1_Load(object sender, EventArgs e)
        {   }
        DriveService service;
        private void button1_Click(object sender, EventArgs e)
        {

            UserCredential credential;

            using (var stream =
                new FileStream("client_id.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/drive-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                logger("Credential file saved to: " + credPath);
            }

            // Create Drive API service.
              service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            
            // Define parameters of request.
            FilesResource.ListRequest listRequest = service.Files.List();
            listRequest.PageSize = 10;
            listRequest.Fields = "nextPageToken, files(id, name)";

            // List files.
            IList<Google.Apis.Drive.v3.Data.File> files = listRequest.Execute()
                .Files;
            logger("Files:");
            if (files != null && files.Count > 0)
            {
                foreach (var file in files)
                {
                    logger("{0} ({1})"+ file.Name+","+ file.Id);
                }
            }
            else
            {
                logger("No files found.");
            }
            Console.Read();
        }
        private void logger(string log_str)
        {
            richTextBox1.Text += Environment.NewLine + log_str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Google.Apis.Drive.v3.Data.File> result = new List<Google.Apis.Drive.v3.Data.File>();
            FilesResource.ListRequest request = service.Files.List();
            request.Fields= "nextPageToken, files(id, name, mimeType,parents)";//to ask for these fileds in request
            request.Q = "'root' in parents"; //to get file and folders sored in root of google drive.

            //FilesResource.GetRequest request =service.Files.Get("0BzrFWSIfoWOEZFBUZVV1ekpoeXM");//to get an item 
            
            //service.Files.List().Q = "name='0BzrFWSIfoWOEZFBUZVV1ekpoeXM";//to query like file name or other avalible queryies 
            

           
            do
            {
                try
                {
                    FileList files = request.Execute();

                    result.AddRange(files.Files);
                    request.PageToken = files.NextPageToken;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    request.PageToken = null;
                }
            } while (!String.IsNullOrEmpty(request.PageToken));
        }
    }
}
