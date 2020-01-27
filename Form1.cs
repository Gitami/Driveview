using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace driveview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string alldriveslistname = "";
            string alldriveslisttype = "";
            string alldriveslistlabel = "";
            string alldriveslistsize = "";
            double alldrivessizeconverter = 0;

            double alldrivestotalspace = 0;
            double alldrivestotalspacefree = 0;
            double alldrivestotalspaceused = 0;

            allheadline_label_name.Text = "";
            allheadline_label_type.Text = "Type";
            allheadline_label_label.Text = "Volume Label";
            allheadline_label_size.Text = "Size";

            // Drives....getting drop-down-box content
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo disknfo in allDrives)
            {
                // for "Drive details" pane
                comboBox1.Items.AddRange(new object[] { disknfo.Name + " (" + disknfo.DriveType + ")" });

                // for "All drives" pane
                alldriveslistname = alldriveslistname +
                                    disknfo.Name + "\r\n"
                                    ;

                if (disknfo.DriveType.ToString() == "NoRootDirectory")
                {
                    alldriveslisttype = alldriveslisttype +
                                        "No root" + "\r\n"
                                        ;
                }
                else
                {
                    alldriveslisttype = alldriveslisttype +
                                        disknfo.DriveType + "\r\n"
                                        ;                
                }

                alldriveslistlabel = alldriveslistlabel +
                                    disknfo.VolumeLabel + "\r\n"
                                    ;

                alldrivessizeconverter = (disknfo.TotalSize / 1000000000);
                alldriveslistsize = alldriveslistsize +
                                    alldrivessizeconverter.ToString() + " Gb" + "\r\n"
                                    ;

                alldrivestotalspace = (alldrivestotalspace + disknfo.TotalSize);
                alldrivestotalspacefree = (alldrivestotalspacefree + disknfo.TotalFreeSpace);

            }

            alldrives_label_name.Text = alldriveslistname;
            alldrives_label_type.Text = alldriveslisttype;
            alldrives_label_label.Text = alldriveslistlabel;
            alldrives_label_size.Text = alldriveslistsize;

            alldrivestotalspaceused = ((alldrivestotalspace - alldrivestotalspacefree) / 1000000000);
            alldrivestotalspace = (alldrivestotalspace / 1000000000);
            alldrivestotalspacefree = (alldrivestotalspacefree / 1000000000);

            alldrivestotalspace_label.Text = "Total space: " + alldrivestotalspace.ToString() + " Gb";
            alldrivestotalspaceused_label.Text = "Used Space: " + alldrivestotalspaceused.ToString() + " Gb";
            alldrivestotalspacefree_label.Text = "Free Space: " + alldrivestotalspacefree.ToString() + " Gb";

            label_drivedata_out.Text = ("\r\n" + "Please choose a drive in the dropdown list above.");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            about_label_link1.Text = "www.amite.dk";
            about_label_link2.Text = "http://amite.dk/webtools/disclaimer/";
            about_label_1.Text = "DriveView version 0.10." + "\r\n" +
                                 "\r\n" +
                                 "Written by amite.dk 2006." + "\r\n" +
                                 "\r\n" +
                                 "DriveView is freeware and can be distributed accordingly." + "\r\n" +
                                 "\r\n" +
                                 "Please visit the website for the latest release." + "\r\n" +
                                 "\r\n" +
                                 "Best regards" + "\r\n" +
                                 "\r\n" +
                                 "\r\n" +
                                 "\r\n" +
                                 "Disclaimer:" + "\r\n"
                                 ;
        }

        private void about_label_link2_Click(object sender, EventArgs e)
        {
            string targetURL = @"http://amite.dk/webtools/disclaimer/";
            System.Diagnostics.Process.Start(targetURL);
        }

        private void about_label_link1_Click(object sender, EventArgs e)
        {
            string targetURL = @"http://amite.dk";
            System.Diagnostics.Process.Start(targetURL);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string tmpdrivedata = "";
            string tmpdrivedataout = "";
            string rootdirisdrivedir = "";
            DriveInfo[] allDrives = DriveInfo.GetDrives();


            foreach (DriveInfo disknfo in allDrives)
            {
                if (disknfo.Name + " (" + disknfo.DriveType + ")" == comboBox1.SelectedItem.ToString())
                {
                    if (disknfo.RootDirectory.ToString() != disknfo.Name)
                    {
                        rootdirisdrivedir = disknfo.Name + " (Root = " + disknfo.RootDirectory.ToString() + ")";
                    }
                    else
                    {
                        rootdirisdrivedir = disknfo.Name;
                    }

                    // Type and name (generic for all drives)
                    
                    tmpdrivedata = tmpdrivedata + "\r\n" + 
                                   "Name" + "\r\n" + 
                                   "Type"
                                   ;

                    tmpdrivedataout = tmpdrivedataout + "\r\n" +
                                      rootdirisdrivedir + "\r\n" + 
                                      disknfo.DriveType.ToString()
                                      ;

                    // Drive Picture/Icon
                    
                    if (disknfo.DriveType.ToString() == "Fixed")
                    {
                        drivesdetails_icon.Image = global::driveview.Properties.Resources.drives_hd;
                    }
                    else if (disknfo.DriveType.ToString() == "CDRom")
                    {
                        drivesdetails_icon.Image = global::driveview.Properties.Resources.drives_optic;
                    }
                    else if (disknfo.DriveType.ToString() == "Network")
                    {
                        drivesdetails_icon.Image = global::driveview.Properties.Resources.drives_network;
                    }
                    else if (disknfo.DriveType.ToString() == "NoRootDirectory")
                    {
                        drivesdetails_icon.Image = global::driveview.Properties.Resources.drives_norootdir;
                    }
                    else if (disknfo.DriveType.ToString() == "Ram")
                    {
                        drivesdetails_icon.Image = global::driveview.Properties.Resources.drives_ram;
                    }
                    else if (disknfo.DriveType.ToString() == "Removable")
                    {
                        drivesdetails_icon.Image = global::driveview.Properties.Resources.drives_removeable;
                    }
                    else if (disknfo.DriveType.ToString() == "Unknown")
                    {
                        drivesdetails_icon.Image = global::driveview.Properties.Resources.drives_unknown;
                    }
                    else
                    {
                        drivesdetails_icon.Image = global::driveview.Properties.Resources.drives_unknown;
                    }

                    // Get drive status if possible (IsReady)
                    if (disknfo.IsReady == true)
                    {
                        // Defining variables for later use
                        string currentuserspacedecription1 = "";
                        string currentuserspaceresult2 = "";
                        double currentuserspaceresult2temp = 0;
                        string currentuserspacedecription2 = "";
                        string currentuserspaceresult1 = "";

                        // Converting Bytes to Gigabytes [formel] (((x/1000)/1000)/1000) = y [/formel]
                        // And setting 
                        double converttotalfreespace = (disknfo.TotalFreeSpace / 1000000000);
                        double converttotaldisksize = (disknfo.TotalSize / 1000000000);

                        double totalspaceinuse = (disknfo.TotalSize - disknfo.TotalFreeSpace);
                        double converttotalspaceinuse = ((disknfo.TotalSize - disknfo.TotalFreeSpace) / 1000000000);

                        if (disknfo.AvailableFreeSpace != disknfo.TotalFreeSpace)
                        {
                            currentuserspacedecription1 = "\r\n" + "Current User";
                            currentuserspacedecription2 = "\r\n" + "Free space";
                            currentuserspaceresult1 = ("\r\n" + System.Environment.UserName.ToString());
                            currentuserspaceresult2temp = (disknfo.AvailableFreeSpace / 1000000000);
                            currentuserspaceresult2 = ("\r\n" + currentuserspaceresult2temp.ToString() + " Gb (" + disknfo.AvailableFreeSpace.ToString() + " bytes)");
                        }
                        
                        tmpdrivedata = tmpdrivedata + "\r\n" +
                                        "Label" + "\r\n" +
                                        "Format" + "\r\n" +
                                        "\r\n" +
                                        "Drive size" + "\r\n" +
                                        "Free space" + "\r\n" +
                                        "Used space" + "\r\n" +
                                        currentuserspacedecription1 +
                                        currentuserspacedecription2
                                        ;

                        tmpdrivedataout = tmpdrivedataout + "\r\n" +
                                          disknfo.VolumeLabel + "\r\n" +
                                          disknfo.DriveFormat + "\r\n" +
                                          "\r\n" +
                                          converttotaldisksize.ToString() + " Gb (" + disknfo.TotalSize.ToString() + " bytes)" + "\r\n" +
                                          converttotalfreespace.ToString() + " Gb (" + disknfo.TotalFreeSpace.ToString() + " bytes)" + "\r\n" +
                                          converttotalspaceinuse.ToString() + " Gb (" + totalspaceinuse.ToString() + " bytes)" + "\r\n" +
                                          currentuserspaceresult1 +
                                          currentuserspaceresult2
                                          ;

                    }
                else
                    {
                        tmpdrivedata = tmpdrivedata + "\r\n" + "Unit Storage Media";
                        tmpdrivedataout = tmpdrivedataout + "\r\n" + "Not Inserted";
                    }
                }
            else
                {
                }
                label_drivedata.Text = tmpdrivedata;
                label_drivedata_out.Text = tmpdrivedataout;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        }

    }
