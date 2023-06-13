using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООП_ЛР_27__Чеботарьов_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            driveComboBox.SelectedIndexChanged += driveComboBox_SelectedIndexChanged;
            driveComboBox.SelectedIndexChanged += driveComboBox_SelectedIndexChanged;
            viewPropertiesButton.Click += viewPropertiesButton_Click;
            viewContentButton.Click += viewContentButton_Click;
            viewSecurityButton.Click += viewSecurityButton_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDriveList();
        }
        private void LoadDriveList()
        {
            string[] drives = Directory.GetLogicalDrives();
            driveComboBox.Items.AddRange(drives);
        }

        private void driveComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDrive = driveComboBox.SelectedItem.ToString();
            DisplayDriveProperties(selectedDrive);
            LoadDirectory(selectedDrive);
        }

        private void LoadDirectory(string path)
        {
            directoryListBox.Items.Clear();
            fileListBox.Items.Clear();

            try
            {
                string[] directories = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);

                directoryListBox.Items.AddRange(directories);
                fileListBox.Items.AddRange(files);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load directory: {ex.Message}", "Error");
            }
        }

        private void directoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDirectory = directoryListBox.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedDirectory))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(selectedDirectory);
                ShowDirectoryProperties(directoryInfo);
            }
        }

        private FileInfo GetSelectedFile()
        {
            string selectedFile = fileListBox.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedFile))
            {
                return new FileInfo(selectedFile);
            }
            return null;
        }

        private void ShowSecurityAttributes(string path)
        {
            try
            {
                FileSecurity fileSecurity = File.GetAccessControl(path);
                AuthorizationRuleCollection accessRules = fileSecurity.GetAccessRules(true, true, typeof(System.Security.Principal.SecurityIdentifier));

                StringBuilder sb = new StringBuilder();
                foreach (FileSystemAccessRule rule in accessRules)
                {
                    sb.AppendLine($"Identity: {rule.IdentityReference}");
                    sb.AppendLine($"Type: {rule.AccessControlType}");
                    sb.AppendLine($"Rights: {rule.FileSystemRights}");
                    sb.AppendLine();
                }

                // Відображення атрибутів безпеки у richTextBox з назвою propertiesRichTextBox
                propertiesRichTextBox.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to retrieve security attributes: {ex.Message}", "Error");
            }
        }

        private bool IsImageFile(FileInfo fileInfo)
        {
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            string fileExtension = fileInfo.Extension.ToLower();
            return imageExtensions.Contains(fileExtension);
        }
        private bool IsTextFile(FileInfo fileInfo)
        {
            string[] textExtensions = { ".txt", ".log", ".csv" };
            string fileExtension = fileInfo.Extension.ToLower();
            return textExtensions.Contains(fileExtension);
        }

        private void DisplayDriveProperties(string drive)
        {
            DriveInfo driveInfo = new DriveInfo(drive);
            MessageBox.Show($"Drive Name: {driveInfo.Name}\n" +
                            $"Drive Type: {driveInfo.DriveType}\n" +
                            $"Total Size: {driveInfo.TotalSize} bytes\n" +
                            $"Available Free Space: {driveInfo.AvailableFreeSpace} bytes", "Drive Properties");

        }

        private void DisplayDirectoryProperties(string directory)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);
            MessageBox.Show($"Directory Name: {directoryInfo.Name}\n" +
                            $"Parent Directory: {directoryInfo.Parent}\n" +
                            $"Created: {directoryInfo.CreationTime}\n" +
                            $"Last Modified: {directoryInfo.LastWriteTime}", "Directory Properties");
        }

        private void DisplayFileProperties(string file)
        {
            FileInfo fileInfo = new FileInfo(file);
            MessageBox.Show($"File Name: {fileInfo.Name}\n" +
                            $"Size: {fileInfo.Length} bytes\n" +
                            $"Created: {fileInfo.CreationTime}\n" +
                            $"Last Modified: {fileInfo.LastWriteTime}", "File Properties");
        }

        private void ShowDirectoryProperties(DirectoryInfo directoryInfo)
        {
            // Виведення основних властивостей виділеного каталогу
            string properties = $"Name: {directoryInfo.Name}\n";
            properties += $"Path: {directoryInfo.FullName}\n";
            properties += $"Creation Time: {directoryInfo.CreationTime}\n";
            properties += $"Last Modified: {directoryInfo.LastWriteTime}\n";
            properties += $"Attributes: {directoryInfo.Attributes}\n";

            // Відображення властивостей у richTextBox з назвою propertiesRichTextBox
            propertiesRichTextBox.Text = properties;
        }

        private void ShowFileProperties(FileInfo fileInfo)
        {
            // Виведення основних властивостей виділеного файлу
            string properties = $"Name: {fileInfo.Name}\n";
            properties += $"Path: {fileInfo.FullName}\n";
            properties += $"Size: {fileInfo.Length} bytes\n";
            properties += $"Creation Time: {fileInfo.CreationTime}\n";
            properties += $"Last Modified: {fileInfo.LastWriteTime}\n";
            properties += $"Attributes: {fileInfo.Attributes}\n";

            // Відображення властивостей у richTextBox з назвою propertiesRichTextBox
            propertiesRichTextBox.Text = properties;
        }
        private void filterButton_Click(object sender, EventArgs e)
        {
            string filter = filterTextBox.Text.ToLower();
            ApplyFileFilter(filter);
            ApplyDirectoryFilter(filter);
        }
        private void ApplyFileFilter(string filter)
        {
            List<string> filteredFiles = new List<string>();

            foreach (string file in fileListBox.Items)
            {
                if (Path.GetFileName(file).ToLower().Contains(filter))
                {
                    filteredFiles.Add(file);
                }
            }

            fileListBox.DataSource = filteredFiles;
        }

        private void ApplyDirectoryFilter(string filter)
        {
            List<string> filteredDirectories = new List<string>();

            foreach (string directory in directoryListBox.Items)
            {
                if (Path.GetFileName(directory).ToLower().Contains(filter))
                {
                    filteredDirectories.Add(directory);
                }
            }

            directoryListBox.DataSource = filteredDirectories;
        }

        private void viewPropertiesButton_Click(object sender, EventArgs e)
        {
            string selectedPath = GetSelectedPath();
            if (!string.IsNullOrEmpty(selectedPath))
            {
                if (IsDirectorySelected())
                {
                    DisplayDirectoryProperties(selectedPath);
                }
                else if (IsFileSelected())
                {
                    DisplayFileProperties(selectedPath);
                }
            }
        }

        private void viewContentButton_Click(object sender, EventArgs e)
        {
            FileInfo selectedFile = GetSelectedFile();
            if (selectedFile != null)
            {
                string selectedPath = selectedFile.FullName;
                if (IsTextFile(selectedPath))
                {
                    string fileContent = File.ReadAllText(selectedPath);
                    contentTextBox.Text = fileContent;
                    pictureBox.Image = null;  // Очистити PictureBox
                }
                else if (IsImageFile(selectedFile))
                {
                    contentTextBox.Text = string.Empty;  // Очистити текстове поле
                    try
                    {
                        Image image = Image.FromFile(selectedFile.FullName);
                        pictureBox.Image = image;
                    }
                    catch (Exception ex)
                    {
                        pictureBox.Image = null;
                        MessageBox.Show($"Failed to load image: {ex.Message}", "Error");
                    }
                }
                else
                {
                    contentTextBox.Text = "The selected file is not a text or image file.";
                    pictureBox.Image = null;  // Очистити PictureBox
                }
            }
            else
            {
                contentTextBox.Text = string.Empty;  // Очистити текстове поле
                pictureBox.Image = null;  // Очистити PictureBox
            }

        }

        private void viewSecurityButton_Click(object sender, EventArgs e)
        {
            string selectedPath = GetSelectedPath();
            if (!string.IsNullOrEmpty(selectedPath))
            {
                DisplaySecurityAttributes(selectedPath);
            }
        }
        private string GetSelectedPath()
        {
            if (IsDirectorySelected())
            {
                return directoryListBox.SelectedItem as string;
            }
            else if (IsFileSelected())
            {
                return fileListBox.SelectedItem as string;
            }
            return null;
        }

        private bool IsDirectorySelected()
        {
            return directoryListBox.SelectedItem != null;
        }

        private bool IsFileSelected()
        {
            return fileListBox.SelectedItem != null;
        }

        private bool IsTextFile(string filePath)
        {
            string[] textExtensions = { ".txt", ".log", ".csv" };
            string fileExtension = Path.GetExtension(filePath).ToLower();
            return textExtensions.Contains(fileExtension);
        }

        private void DisplaySecurityAttributes(string path)
        {
            try
            {
                FileSecurity fileSecurity = File.GetAccessControl(path);
                AuthorizationRuleCollection accessRules = fileSecurity.GetAccessRules(true, true, typeof(System.Security.Principal.SecurityIdentifier));

                StringBuilder sb = new StringBuilder();
                foreach (FileSystemAccessRule rule in accessRules)
                {
                    sb.AppendLine($"Identity: {rule.IdentityReference}");
                    sb.AppendLine($"Type: {rule.AccessControlType}");
                    sb.AppendLine($"Rights: {rule.FileSystemRights}");
                    sb.AppendLine();
                }

                propertiesRichTextBox.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to retrieve security attributes: {ex.Message}", "Error");
            }
        }
    }
}
