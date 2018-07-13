using System;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SanityArchiver
{
    public partial class Form1 : Form
    {
        private DirectoryInfo directInfo = new DirectoryInfo(@"c:\");
        private string selectedPath;
        private string selectedPath2;

        public Form1()
        {
            InitializeComponent();
        }

        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            
            selectedPath = @"c:\";
            pathTextBox.Text = @"c:\";
            loadDirandFiles(selectedPath, 1);
            pathTextBox2.Text = @"c:\";
            selectedPath2 = @"c:\";
            loadDirandFiles(selectedPath2, 2);
    }

        private void openButton_Click(object sender, EventArgs e)
        {
            loadFolderBrowser(1);
        }

        private void openButton2_Click(object sender, EventArgs e)
        {
            loadFolderBrowser(2);
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = pathTextBox.Text + @"\" + listView1.SelectedItems[0].Text;
                nameTextBox.Text = listView1.SelectedItems[0].Text;
                Compress.Text = (nameTextBox.Text.Contains(".gz")) ? "Decompress" : "Compress";
                compressToolStripMenuItem.Text = (nameTextBox.Text.Contains(".gz")) ? "Decompress" : "Compress";

                FileInfo fileInfo = new FileInfo(filePath);
                using (FileStream originalFileStream = fileInfo.OpenRead())
                {
                    FileAttributes attributes = File.GetAttributes(fileInfo.FullName);
                    Crypt.Text = ((attributes & FileAttributes.Encrypted) == FileAttributes.Encrypted) ? "Decrypt" : "Crypt";
                    qqToolStripMenuItem.Text = ((attributes & FileAttributes.Encrypted) == FileAttributes.Encrypted) ? "Decrypt" : "Crypt";

                    adasdToolStripMenuItem.Text = ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden) ? "Unhide" : "Hide";
                    readOnlyToolStripMenuItem.Text = ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly) ? "Readable" : "Ready-Only";
                }
            }
            catch (Exception)
            {
            }  
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string filename = pathTextBox.Text + @"\" + listView1.SelectedItems[0].Text;
            System.Diagnostics.Process.Start(filename);
        }

        private void listView2_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = pathTextBox2.Text + @"\" + listView2.SelectedItems[0].Text;
                nameTextBox2.Text = listView2.SelectedItems[0].Text;
                Compress.Text = (nameTextBox2.Text.Contains(".gz")) ? "Decompress" : "Compress";
                compressToolStripMenuItem.Text = (nameTextBox.Text.Contains(".gz")) ? "Decompress" : "Compress";

                FileInfo fileInfo = new FileInfo(filePath);
                using (FileStream originalFileStream = fileInfo.OpenRead())
                {
                    FileAttributes attributes = File.GetAttributes(fileInfo.FullName);
                    Crypt.Text = ((attributes & FileAttributes.Encrypted) == FileAttributes.Encrypted) ? "Decrypt" : "Crypt";
                    qqToolStripMenuItem.Text = ((attributes & FileAttributes.Encrypted) == FileAttributes.Encrypted) ? "Decrypt" : "Crypt";
                    adasdToolStripMenuItem.Text = ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden) ? "Unhide" : "Hide";
                    readOnlyToolStripMenuItem.Text = ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly) ? "Readable" : "Ready-Only";
                }
            }
            catch (Exception)
            {
            }
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            string filename = pathTextBox2.Text + @"\" + listView2.SelectedItems[0].Text;
            System.Diagnostics.Process.Start(filename);
        }

        private void Compress_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = pathTextBox.Text + @"\" + listView1.SelectedItems[0].Text;
                FileInfo fi = new FileInfo(filePath);
                if (Compress.Text == "Compress")
                {
                    CompressFIle(fi);
                }
                else
                {
                    Decompress(fi);
                }
            }
            catch (Exception)
            {
                try
                {
                    string filePath = pathTextBox2.Text + @"\" + listView2.SelectedItems[0].Text;
                    FileInfo fi = new FileInfo(filePath);
                    if (Compress.Text == "Compress")
                    {
                        CompressFIle(fi);
                    }
                    else
                    {
                        Decompress(fi);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("File not exist");
                }
            }
            
            loadDirandFiles(nameTextBox.Text,1);
            loadDirandFiles(nameTextBox2.Text,2);
        }

        private void Crypt_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = pathTextBox.Text + @"\" + listView1.SelectedItems[0].Text;
                if (Crypt.Text == "Decrypt")
                {
                    deCrypt(filePath);
                }
                else
                {
                    crypt(filePath);
                }
            }
            catch (Exception)
            {
                try
                {
                    string filePath = pathTextBox2.Text + @"\" + listView2.SelectedItems[0].Text;
                    if (Crypt.Text == "Decrypt")
                    {
                        deCrypt(filePath);
                    }
                    else
                    {
                        crypt(filePath);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("File not exist");
                }
            }
            loadDirandFiles(nameTextBox.Text,1);
            loadDirandFiles(nameTextBox2.Text,2);
        }

        private void fileDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = pathTextBox.Text + @"\" + listView1.SelectedItems[0].Text;
                deleteFile(path);
            }
            catch (Exception)
            {
                try
                {
                    string path = pathTextBox2.Text + @"\" + listView2.SelectedItems[0].Text;
                    deleteFile(path);
                }
                catch (Exception)
                {
                    MessageBox.Show("File not exist");
                }
            }
            loadDirandFiles(nameTextBox.Text,1);
            loadDirandFiles(nameTextBox2.Text,2);
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = listView1.SelectedItems[0].Text;
                string sourcePath = pathTextBox.Text;
                string targetPath = pathTextBox2.Text;

                string sourceFile = Path.Combine(sourcePath, fileName);
                string destFile = Path.Combine(targetPath, fileName);

                if (Directory.Exists(targetPath))
                {
                    Directory.CreateDirectory(targetPath);
                }
                File.Copy(sourceFile, destFile, true);
            }
            catch (Exception)
            {
                try
                {
                    string fileName = listView2.SelectedItems[0].Text;
                    string sourcePath = pathTextBox2.Text;
                    string targetPath = pathTextBox.Text;

                    string sourceFile = Path.Combine(sourcePath, fileName);
                    string destFile = Path.Combine(targetPath, fileName);

                    if (Directory.Exists(targetPath))
                    {
                        Directory.CreateDirectory(targetPath);
                    }
                    File.Copy(sourceFile, destFile, true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Choose a destination directory");
                }
            }
            loadDirandFiles(nameTextBox.Text, 1);
            loadDirandFiles(nameTextBox2.Text, 2);
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string sourceFile = pathTextBox.Text + @"\" + listView1.SelectedItems[0].Text;
                string destinationFile = pathTextBox2.Text + @"\" + listView1.SelectedItems[0].Text;
                File.Move(sourceFile, destinationFile);
            }
            catch (Exception)
            {
                try
                {
                    string sourceFile = pathTextBox2.Text + @"\" + listView2.SelectedItems[0].Text;
                    string destinationFile = pathTextBox.Text + @"\" + listView2.SelectedItems[0].Text;
                    File.Move(sourceFile, destinationFile);
                }
                catch (Exception)
                {
                    MessageBox.Show("Choose a destination directory");
                }
            }
            loadDirandFiles(nameTextBox.Text, 1);
            loadDirandFiles(nameTextBox2.Text, 2);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (searchBox.TextLength > 0)
                {
                    listView1.Clear();

                    foreach (string item in Directory.GetFiles(selectedPath))
                    {
                        if (item.Contains(searchBox.Text))
                        {
                            imageList1.Images.Add(Icon.ExtractAssociatedIcon(item));
                            FileInfo fi = new FileInfo(item);
                            listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);
                        }
                    }
                }
                else
                {
                    loadDirandFiles(pathTextBox.Text, 1);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Search error");
            }
        }
        
        private void searchBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (searchBox2.TextLength > 0)
                {
                    listView2.Clear();

                    foreach (string item in Directory.GetFiles(selectedPath2))
                    {
                        if (item.Contains(searchBox2.Text))
                        {
                            imageList1.Images.Add(Icon.ExtractAssociatedIcon(item));
                            FileInfo fi = new FileInfo(item);
                            listView2.Items.Add(fi.Name, imageList1.Images.Count - 1);
                        }
                    }
                }
                else
                {
                    loadDirandFiles(pathTextBox2.Text, 2);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Search error");
            }
        }

        //Hide Unhide click
        private void adasdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = pathTextBox.Text + @"\" + listView1.SelectedItems[0].Text;
                FileInfo fi = new FileInfo(filePath);
                FileAttributes attributes = File.GetAttributes(fi.FullName);
                
                
                if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                {
                    // Show the file.
                    attributes = RemoveAttribute(attributes, FileAttributes.Hidden);
                    File.SetAttributes(filePath, attributes);
                }
                else
                {
                    // Hide the filefilePath
                    File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.Hidden);
                }
                
            }
            catch (Exception ex)
            {
                try
                {
                    string filePath = pathTextBox2.Text + @"\" + listView2.SelectedItems[0].Text;
                    FileInfo fi = new FileInfo(filePath);
                    FileAttributes attributes = File.GetAttributes(fi.FullName);
                    
                    if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                    {
                        // Show the file.
                        attributes = RemoveAttribute(attributes, FileAttributes.Hidden);
                        File.SetAttributes(filePath, attributes);
                    }
                    else
                    {
                        // Hide the filefilePath
                        File.SetAttributes(filePath, File.GetAttributes(filePath) | FileAttributes.Hidden);
                    }   
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("Hide Error: " + ex2.Message);
                }
            }
        }
        #endregion

        #region Events functions
        private void loadFolderBrowser(int tabelNumber)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    if (tabelNumber == 1)
                    {
                        selectedPath = fbd.SelectedPath;
                        pathTextBox.Text = fbd.SelectedPath;
                        loadDirandFiles(selectedPath, tabelNumber);
                    }
                    else
                    {
                        selectedPath2 = fbd.SelectedPath;
                        pathTextBox2.Text = fbd.SelectedPath;
                        loadDirandFiles(selectedPath, tabelNumber);
                    }
                }      
            }
        }

        private void loadDirandFiles(string path, int tabelNumber)
        {
            if (tabelNumber == 1 & !String.IsNullOrEmpty(selectedPath))
            {
                try
                {
                    listView1.Clear();
                    foreach (string item in Directory.GetDirectories(selectedPath))
                    {
                        DirectoryInfo di = new DirectoryInfo(item);
                        listView1.Items.Add(item, 0);
                    }
                    foreach (string item in Directory.GetFiles(selectedPath))
                    {
                        imageList1.Images.Add(Icon.ExtractAssociatedIcon(item));
                        FileInfo fi = new FileInfo(item);
                        listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);
                    }
                    calculateDirectorySize(selectedPath, 1);
                }
                catch (Exception)
                {
                    MessageBox.Show("Choose directory in 1st row");
                }
            }
            else if(tabelNumber == 2 & !String.IsNullOrEmpty(selectedPath))
            {
                try
                {
                    listView2.Clear();
                    foreach (string item in Directory.GetDirectories(selectedPath2))
                    {
                        DirectoryInfo di = new DirectoryInfo(item);
                        listView2.Items.Add(item, 0);
                    }
                    foreach (string item in Directory.GetFiles(selectedPath2))
                    {
                        imageList1.Images.Add(Icon.ExtractAssociatedIcon(item));
                        FileInfo fi = new FileInfo(item);
                        listView2.Items.Add(fi.Name, imageList1.Images.Count - 1);
                    }
                    calculateDirectorySize(selectedPath2, 2);
                }
                catch (Exception)
                {
                    MessageBox.Show("Choose directory in 2nd row");
                }
            }
        }

        private void CompressFIle(FileInfo fi)
        {
            FileStream originalFileStream = fi.OpenRead();

            if ((File.GetAttributes(fi.FullName) & FileAttributes.Hidden) != FileAttributes.Hidden & fi.Extension != ".gz")
            {
                using (FileStream compressedFileStream = File.Create(fi.FullName + ".gz"))
                {
                    using (GZipStream compressionStream = new GZipStream(compressedFileStream,
                        CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
            }
            originalFileStream.Close();
        }

        private void Decompress(FileInfo fi)
        {
            using (FileStream originalFileStream = fi.OpenRead())
            {
                string currentFileName = fi.FullName;
                string newFileName = currentFileName.Remove(currentFileName.Length - fi.Extension.Length);

                using (FileStream decompressedFileStream = File.Create(newFileName))
                {
                    using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                    }
                }
            }
        }

        private void crypt(string filePath)
        {
            File.Encrypt(filePath);
        }

        private void deCrypt(string filePath)
        {
            File.Decrypt(filePath);
        }

        private void deleteFile(string filePath)
        {
            File.Delete(filePath);
        }

        private void calculateDirectorySize(string path, int listNumber)
        {
            switch (listNumber)
            {
                case 1:
                    string[] a = Directory.GetFiles(path, "*.*");

                    long b = 0;
                    foreach (string name in a)
                    {
                        FileInfo info = new FileInfo(name);
                        b += info.Length;
                    }
                    label5.Text = "Directory size: " + b.ToString();
                    break;
                case 2:
                    string[] a2 = Directory.GetFiles(path, "*.*");

                    long b2 = 0;
                    foreach (string name in a2)
                    {
                        FileInfo info = new FileInfo(name);
                        b2 += info.Length;
                    }
                    label6.Text = "Directory size: " + b2.ToString();
                    break;
                default:
                    break;
            }
        }

        private FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
        {
            return attributes & ~attributesToRemove;
        }
        #endregion

        //Set unset readonly
        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = pathTextBox.Text + @"\" + listView1.SelectedItems[0].Text;
                FileAttributes attributes = File.GetAttributes(filePath);

                if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                {
                    // unset Read only on file.
                    attributes = attributes & ~FileAttributes.ReadOnly;
                    File.SetAttributes(filePath, attributes);
                }
                else
                {
                    // set Read only on file.
                    attributes = attributes | FileAttributes.ReadOnly;
                    File.SetAttributes(filePath, attributes);
                }
            }
            catch (Exception)
            {

                try
                {
                    string filePath = pathTextBox2.Text + @"\" + listView2.SelectedItems[0].Text;
                    FileAttributes attributes = File.GetAttributes(filePath);

                    if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                    {
                        // unset Read only on file.
                        attributes = attributes & ~FileAttributes.ReadOnly;
                        File.SetAttributes(filePath, attributes);
                    }
                    else
                    {
                        // set Read only on file.
                        attributes = attributes | FileAttributes.ReadOnly;
                        File.SetAttributes(filePath, attributes);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("ReadOnly fault");
                }
            }
        }

    }
}
