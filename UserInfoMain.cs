/**********************************************************
 * Demo for Standalone SDK.Created by Darcy on Sep 2023*
***********************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DatabaseClassLibrary;
using System.Data.SqlClient;
using System.Linq;

using System.Threading;

namespace UserInfo
{
    public partial class UserInfoMain : Form
    {
        public UserInfoMain()
        {
            InitializeComponent();
        }

        //Create Standalone SDK class dynamicly.
        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();

        #region Communication
        private bool bIsConnected = false;//the boolean value identifies whether the device is connected
        private int iMachineNumber = 1;//the serial number of the device.After connecting the device ,this value will be changed.


        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtIP.Text.Trim() == "" || txtPort.Text.Trim() == "")
            {
                MessageBox.Show("IP and Port cannot be null", "Error");
                return;
            }
            int idwErrorCode = 0;

            Cursor = Cursors.WaitCursor;
            if (btnConnect.Text == "DisConnect")
            {
                axCZKEM1.Disconnect();

                //Real Time Event Param
                lbRTShow.Items.Add("Disconnected (ibRTfront)... ");
                this.axCZKEM1.OnFinger -= new zkemkeeper._IZKEMEvents_OnFingerEventHandler(axCZKEM1_OnFinger);
                this.axCZKEM1.OnVerify -= new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(axCZKEM1_OnVerify);
                this.axCZKEM1.OnAttTransactionEx -= new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(axCZKEM1_OnAttTransactionEx);
                this.axCZKEM1.OnFingerFeature -= new zkemkeeper._IZKEMEvents_OnFingerFeatureEventHandler(axCZKEM1_OnFingerFeature);
                this.axCZKEM1.OnEnrollFingerEx -= new zkemkeeper._IZKEMEvents_OnEnrollFingerExEventHandler(axCZKEM1_OnEnrollFingerEx);
                this.axCZKEM1.OnDeleteTemplate -= new zkemkeeper._IZKEMEvents_OnDeleteTemplateEventHandler(axCZKEM1_OnDeleteTemplate);
                this.axCZKEM1.OnNewUser -= new zkemkeeper._IZKEMEvents_OnNewUserEventHandler(axCZKEM1_OnNewUser);
                this.axCZKEM1.OnHIDNum -= new zkemkeeper._IZKEMEvents_OnHIDNumEventHandler(axCZKEM1_OnHIDNum);
                this.axCZKEM1.OnAlarm -= new zkemkeeper._IZKEMEvents_OnAlarmEventHandler(axCZKEM1_OnAlarm);
                this.axCZKEM1.OnDoor -= new zkemkeeper._IZKEMEvents_OnDoorEventHandler(axCZKEM1_OnDoor);
                this.axCZKEM1.OnWriteCard -= new zkemkeeper._IZKEMEvents_OnWriteCardEventHandler(axCZKEM1_OnWriteCard);
                this.axCZKEM1.OnEmptyCard -= new zkemkeeper._IZKEMEvents_OnEmptyCardEventHandler(axCZKEM1_OnEmptyCard);

                bIsConnected = false;
                btnConnect.Text = "Connect";
                lblState.Text = "Current State:DisConnected";
                Cursor = Cursors.Default;
                return;
            }

            axCZKEM1.PullMode = 1;
            bIsConnected = axCZKEM1.Connect_Net(txtIP.Text, Convert.ToInt32(txtPort.Text));
            if (bIsConnected == true)
            {
                btnConnect.Text = "DisConnect";
                btnConnect.Refresh();
                lblState.Text = "Current State:Connected";
                iMachineNumber = 1;//In fact,when you are using the tcp/ip communication,this parameter will be ignored,that is any integer will all right.Here we use 1.

                //Real Time Event Param
                if (axCZKEM1.RegEvent(iMachineNumber, 65535))//Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
                {
                    lbRTShow.Items.Add("Connected (ibRTfront)... ");
                    this.axCZKEM1.OnFinger += new zkemkeeper._IZKEMEvents_OnFingerEventHandler(axCZKEM1_OnFinger);
                    this.axCZKEM1.OnVerify += new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(axCZKEM1_OnVerify);
                    this.axCZKEM1.OnAttTransactionEx += new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(axCZKEM1_OnAttTransactionEx);
                    this.axCZKEM1.OnFingerFeature += new zkemkeeper._IZKEMEvents_OnFingerFeatureEventHandler(axCZKEM1_OnFingerFeature);
                    this.axCZKEM1.OnEnrollFingerEx += new zkemkeeper._IZKEMEvents_OnEnrollFingerExEventHandler(axCZKEM1_OnEnrollFingerEx);
                    this.axCZKEM1.OnDeleteTemplate += new zkemkeeper._IZKEMEvents_OnDeleteTemplateEventHandler(axCZKEM1_OnDeleteTemplate);
                    this.axCZKEM1.OnNewUser += new zkemkeeper._IZKEMEvents_OnNewUserEventHandler(axCZKEM1_OnNewUser);
                    this.axCZKEM1.OnHIDNum += new zkemkeeper._IZKEMEvents_OnHIDNumEventHandler(axCZKEM1_OnHIDNum);
                    this.axCZKEM1.OnAlarm += new zkemkeeper._IZKEMEvents_OnAlarmEventHandler(axCZKEM1_OnAlarm);
                    this.axCZKEM1.OnDoor += new zkemkeeper._IZKEMEvents_OnDoorEventHandler(axCZKEM1_OnDoor);
                    this.axCZKEM1.OnWriteCard += new zkemkeeper._IZKEMEvents_OnWriteCardEventHandler(axCZKEM1_OnWriteCard);
                    this.axCZKEM1.OnEmptyCard += new zkemkeeper._IZKEMEvents_OnEmptyCardEventHandler(axCZKEM1_OnEmptyCard);
                }
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("Unable to connect the device,ErrorCode=" + idwErrorCode.ToString(), "Error");
            }
            Cursor = Cursors.Default;
        }

        #endregion

        #region UserInfo

        private void btnDownloadTmp_Click(object sender, EventArgs e)
        {
            if (bIsConnected == false)
            {
                MessageBox.Show("Please connect the device first!", "Error");
                return;
            }

            string sdwEnrollNumber = "";
            string sName = "";
            string sPassword = "";
            int iPrivilege = 0;
            bool bEnabled = false;

            int idwFingerIndex;
            string sTmpData = "";
            int iTmpLength = 0;
            int iFlag = 0;

            lvDownload.Items.Clear();
            lvDownload.BeginUpdate();
            axCZKEM1.EnableDevice(iMachineNumber, false);
            Cursor = Cursors.WaitCursor;

            axCZKEM1.ReadAllUserID(iMachineNumber);//read all the user information to the memory
            axCZKEM1.ReadAllTemplate(iMachineNumber);//read all the users' fingerprint templates to the memory
            while (axCZKEM1.SSR_GetAllUserInfo(iMachineNumber, out sdwEnrollNumber, out sName, out sPassword, out iPrivilege, out bEnabled))//get all the users' information from the memory
            {
                for (idwFingerIndex = 0; idwFingerIndex < 10; idwFingerIndex++)
                {
                    if (axCZKEM1.GetUserTmpExStr(iMachineNumber, sdwEnrollNumber, idwFingerIndex, out iFlag, out sTmpData, out iTmpLength))//get the corresponding templates string and length from the memory
                    {
                        ListViewItem list = new ListViewItem();
                        list.Text = sdwEnrollNumber;
                        list.SubItems.Add(sName);
                        list.SubItems.Add(idwFingerIndex.ToString());
                        list.SubItems.Add(sTmpData);
                        list.SubItems.Add(iPrivilege.ToString());
                        list.SubItems.Add(sPassword);
                        if (bEnabled == true)
                        {
                            list.SubItems.Add("true");
                        }
                        else
                        {
                            list.SubItems.Add("false");
                        }
                        list.SubItems.Add(iFlag.ToString());
                        lvDownload.Items.Add(list);
                    }
                }
            }
            lvDownload.EndUpdate();
            axCZKEM1.EnableDevice(iMachineNumber, true);
            Cursor = Cursors.Default;
        }

        private void addDemo_Click(object sender, EventArgs e)
        {
            LoadUserList();
        }

        private void uploadSQL_Click(object sender, EventArgs e)
        {
            if (lvDownload.Items.Count > 0) //check have table row?
            {
                var list = new List<bool>();
                //begin upload
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=192.168.88.141;Initial Catalog=CarService;User ID=sa;Password=sa0816812178";
                cnn = new SqlConnection(connetionString);
                
                for (int r = 1; r <= lvDownload.Items.Count; r++) // read all (1 by 1)
                {
                    if (lvDownload.Items[r - 1].SubItems[3].Text == "") // check have finger data?
                    {
                        list.Add(false);//no finger data
                    }
                    else
                    {
                        cnn.Open();
                        string selectquery = "select * from EmpFingerEco where FingerCode = '" + lvDownload.Items[r - 1].SubItems[3].Text + "'";
                        SqlCommand cmd = new SqlCommand(selectquery, cnn);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();

                        if (reader1.Read())// found duplicate = not upload to SQL dbo.EmpFingerEco
                        {
                            MessageBox.Show("fingerprint already exist");
                            cnn.Close();
                            return;
                        }
                        else
                        {
                            list.Add(true);
                        }
                    }
                    cnn.Close();
                }

                if (!list.Contains(true))//no finger
                {
                    MessageBox.Show("All data no fingerprint!", "Error");
                }
                else if (!list.Contains(false))//have finger
                {
                    MessageBox.Show("Upload fingerprint!", "Error");

                    cnn.Open();

                    for (int r = 1; r <= lvDownload.Items.Count; r++) // upload to sever SQL (1 by 1)
                    {
                        //String query = @"DECLARE @FingerNumber INT;" + "SELECT @FingerNumber  =  MAX(FingerNumber)+1 from EmpFinger ";//col 1 in SQL (dbo.EmpFinger)
                        String query = "INSERT INTO dbo.EmpFingerEco (EmployeeNumber,EmployeeName,FingerIndex,FingerCode) ";
                        query += "VALUES (@EmployeeNumber,@EmployeeName, @FingerIndex,@FingerCode)";
                        SqlCommand uploadFinger = new SqlCommand(query, cnn);

                        uploadFinger.Parameters.AddWithValue("@EmployeeNumber", lvDownload.Items[r - 1].SubItems[0].Text);//col 1 in SQL (dbo.EmpFingerEco)
                        uploadFinger.Parameters.AddWithValue("@EmployeeName", lvDownload.Items[r - 1].SubItems[1].Text);//col 2 in SQL (dbo.EmpFingerEco)
                        uploadFinger.Parameters.AddWithValue("@FingerIndex", lvDownload.Items[r - 1].SubItems[2].Text);//col 3 in SQL (dbo.EmpFingerEco)
                        uploadFinger.Parameters.AddWithValue("FingerCode", lvDownload.Items[r - 1].SubItems[3].Text);//col 4 in SQL (dbo.EmpFingerEco)
                        uploadFinger.ExecuteNonQuery();  
                    }
                    cnn.Close();
                }
                else//have some
                    MessageBox.Show("not at all!", "Error");
            }
            else
                MessageBox.Show("There is no data to upload!", "Error");
                return;
        }

        private void LoadUserList()
        {
            lvDownload.Items.Clear();

            try
            {
                string connetionString;
                SqlConnection cnn;
                SqlCommand cmd;
                SqlCommand cmdIndex;
                connetionString = @"Data Source=192.168.88.141;Initial Catalog=CarService;User ID=sa;Password=sa0816812178";
                cnn = new SqlConnection(connetionString);

                cmd = new SqlCommand("select * from Employee", cnn);
                cmdIndex = new SqlCommand("select * from EmpIndex", cnn);

                string selectquery = "select * from Employee ";
                selectquery += "where EmployeeID = 66010007070001"; //for demo test
                string selectqueryIndex = "select * from EmpIndex";

                SqlDataAdapter adpt = new SqlDataAdapter(selectquery, cnn);
                SqlDataAdapter adptIndex = new SqlDataAdapter(selectqueryIndex, cnn);

                DataTable table = new DataTable();
                DataTable tableIndex = new DataTable();

                adpt.Fill(table);
                adptIndex.Fill(tableIndex);

                var empJoin = (from TBEmp in table.AsEnumerable() join TBFinger in tableIndex.AsEnumerable()
                              on TBEmp.Field<string>("EmployeeID") equals TBFinger.Field<string>("EmployeeID")
                              into tempJoin from leftJoin in tempJoin.DefaultIfEmpty()
                              select new
                              {
                                  EmpID = TBEmp.Field<string>("EmployeeID"),
                                  EmpName = TBEmp.Field<string>("EmployeeName"),
                                  EmpIndex = leftJoin == null ? "empty" : leftJoin.Field<string>("EmployeeNumber")
                              });

                int numRows = 0;

                foreach (var item in empJoin)
                {
                    //Console.WriteLine(String.Format("EmpID = {0}, EmpName = {1}, EmpIndex = {2}", 
                    //    item.EmpID, item.EmpName, item.EmpIndex));
                    numRows++;

                    //set demo value
                    string sdwEnrollNumber = item.EmpIndex;
                    string sName = item.EmpName;
                    string sPassword = "";
                    int iPrivilege = 0;
                    bool bEnabled = true;

                    int idwFingerIndex = 0;
                    string sTmpData = "";
                    //int iTmpLength = 0;
                    int iFlag = 1;

                    //add to list table
                    ListViewItem list = new ListViewItem();
                    list.Text = sdwEnrollNumber;
                    list.SubItems.Add(sName);
                    list.SubItems.Add(idwFingerIndex.ToString());
                    list.SubItems.Add(sTmpData);
                    list.SubItems.Add(iPrivilege.ToString());
                    list.SubItems.Add(sPassword);
                    if (bEnabled == true)
                    {
                        list.SubItems.Add("true");
                    }
                    else
                    {
                        list.SubItems.Add("false");
                    }
                    list.SubItems.Add(iFlag.ToString());
                    lvDownload.Items.Add(list);
                }
            }
            catch (SystemException ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnBatchUpdate_Click(object sender, EventArgs e)
        {
            if (bIsConnected == false)
            {
                MessageBox.Show("Please connect the device first!", "Error");
                return;
            }

            if (lvDownload.Items.Count == 0)
            {
                MessageBox.Show("There is no data to upload!", "Error");
                return;
            }
            int idwErrorCode = 0;

            string sdwEnrollNumber = "";
            string sName = "";
            int idwFingerIndex = 0;
            string sTmpData = "";
            int iPrivilege = 0;
            string sPassword = "";
            string sEnabled = "";
            bool bEnabled = false;
            int iFlag = 1;

            int iUpdateFlag = 1;

            Cursor = Cursors.WaitCursor;
            axCZKEM1.EnableDevice(iMachineNumber, false);
            if (axCZKEM1.BeginBatchUpdate(iMachineNumber, iUpdateFlag))//create memory space for batching data
            {
                string sLastEnrollNumber = "";//the former enrollnumber you have upload(define original value as 0)
                for (int i = 0; i < lvDownload.Items.Count; i++)
                {
                    sdwEnrollNumber = lvDownload.Items[i].SubItems[0].Text;
                    sName = lvDownload.Items[i].SubItems[1].Text;
                    idwFingerIndex = Convert.ToInt32(lvDownload.Items[i].SubItems[2].Text);
                    sTmpData = lvDownload.Items[i].SubItems[3].Text;
                    iPrivilege = Convert.ToInt32(lvDownload.Items[i].SubItems[4].Text);
                    sPassword = lvDownload.Items[i].SubItems[5].Text;
                    sEnabled = lvDownload.Items[i].SubItems[6].Text;
                    iFlag = Convert.ToInt32(lvDownload.Items[i].SubItems[7].Text);

                    if (sEnabled == "true")
                    {
                        bEnabled = true;
                    }
                    else
                    {
                        bEnabled = false;
                    }
                    if (sdwEnrollNumber != sLastEnrollNumber)//identify whether the user information(except fingerprint templates) has been uploaded
                    {
                        if (axCZKEM1.SSR_SetUserInfo(iMachineNumber, sdwEnrollNumber, sName, sPassword, iPrivilege, bEnabled))//upload user information to the memory
                        {
                            axCZKEM1.SetUserTmpExStr(iMachineNumber, sdwEnrollNumber, idwFingerIndex, iFlag, sTmpData);//upload templates information to the memory
                        }
                        else
                        {
                            axCZKEM1.GetLastError(ref idwErrorCode);
                            MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
                            Cursor = Cursors.Default;
                            axCZKEM1.EnableDevice(iMachineNumber, true);
                            return;
                        }
                    }
                    else//the current fingerprint and the former one belongs the same user,that is ,one user has more than one template
                    {
                        axCZKEM1.SetUserTmpExStr(iMachineNumber, sdwEnrollNumber, idwFingerIndex, iFlag, sTmpData);
                    }
                    sLastEnrollNumber = sdwEnrollNumber;//change the value of iLastEnrollNumber dynamicly
                }
            }
            axCZKEM1.BatchUpdate(iMachineNumber);//upload all the information in the memory
            axCZKEM1.RefreshData(iMachineNumber);//the data in the device should be refreshed
            Cursor = Cursors.Default;
            axCZKEM1.EnableDevice(iMachineNumber, true);
            MessageBox.Show("Successfully upload fingerprint templates in batches , " + "total:" + lvDownload.Items.Count.ToString(), "Success");
        }


        private void btnUploadTmp_Click(object sender, EventArgs e)
        {
            if (bIsConnected == false)
            {
                MessageBox.Show("Please connect the device first!", "Error");
                return;
            }

            if (lvDownload.Items.Count == 0)
            {
                MessageBox.Show("There is no data to upload!", "Error");
                return;
            }
            int idwErrorCode = 0;

            string sdwEnrollNumber = "";
            string sName = "";
            int idwFingerIndex = 0;
            string sTmpData = "";
            int iPrivilege = 0;
            string sPassword = "";
            int iFlag = 0;
            string sEnabled = "";
            bool bEnabled = false;

            Cursor = Cursors.WaitCursor;
            axCZKEM1.EnableDevice(iMachineNumber, false);
            for (int i = 0; i < lvDownload.Items.Count; i++)
            {
                sdwEnrollNumber = lvDownload.Items[i].SubItems[0].Text.Trim();
                sName = lvDownload.Items[i].SubItems[1].Text.Trim();
                idwFingerIndex = Convert.ToInt32(lvDownload.Items[i].SubItems[2].Text.Trim());
                sTmpData = lvDownload.Items[i].SubItems[3].Text.Trim();
                iPrivilege = Convert.ToInt32(lvDownload.Items[i].SubItems[4].Text.Trim());
                sPassword = lvDownload.Items[i].SubItems[5].Text.Trim();

                sEnabled = lvDownload.Items[i].SubItems[6].Text.Trim();
                iFlag = Convert.ToInt32(lvDownload.Items[i].SubItems[7].Text);
                if (sEnabled == "true")
                {
                    bEnabled = true;
                }
                else
                {
                    bEnabled = false;
                }

                if (axCZKEM1.SSR_SetUserInfo(iMachineNumber, sdwEnrollNumber, sName, sPassword, iPrivilege, bEnabled))//upload user information to the device
                {
                    axCZKEM1.SetUserTmpExStr(iMachineNumber, sdwEnrollNumber, idwFingerIndex, iFlag, sTmpData);//upload templates information to the device
                }
                else
                {
                    axCZKEM1.GetLastError(ref idwErrorCode);
                    MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
                    Cursor = Cursors.Default;
                    axCZKEM1.EnableDevice(iMachineNumber, true);
                    return;
                }
            }
            axCZKEM1.RefreshData(iMachineNumber);//the data in the device should be refreshed
            Cursor = Cursors.Default;
            axCZKEM1.EnableDevice(iMachineNumber, true);
            MessageBox.Show("Successfully Upload fingerprint templates, " + "total:" + lvDownload.Items.Count.ToString(), "Success");
        }

        private void btnSSR_DelUserTmpExt_Click(object sender, EventArgs e)
        {
            if (bIsConnected == false)
            {
                MessageBox.Show("Please connect the device first!", "Error");
                return;
            }

            if (cbUserIDTmp.Text.Trim() == "" || cbFingerIndex.Text.Trim() == "")
            {
                MessageBox.Show("Please input the UserID and FingerIndex first!", "Error");
                return;
            }
            int idwErrorCode = 0;

            string sUserID = cbUserIDTmp.Text.Trim();
            int iFingerIndex = Convert.ToInt32(cbFingerIndex.Text.Trim());

            Cursor = Cursors.WaitCursor;
            if (axCZKEM1.SSR_DelUserTmpExt(iMachineNumber, sUserID, iFingerIndex))
            {
                axCZKEM1.RefreshData(iMachineNumber);//the data in the device should be refreshed
                MessageBox.Show("SSR_DelUserTmpExt,UserID:" + sUserID + " FingerIndex:" + iFingerIndex.ToString(), "Success");
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
            }
            Cursor = Cursors.Default;
        }

        //Clear all the fingerprint templates in the device(While the parameter DataFlag  of the Function "ClearData" is 2 )
        private void btnClearDataTmps_Click(object sender, EventArgs e)
        {
            if (bIsConnected == false)
            {
                MessageBox.Show("Please connect the device first!", "Error");
                return;
            }
            int idwErrorCode = 0;

            int iDataFlag = 2;

            Cursor = Cursors.WaitCursor;
            if (axCZKEM1.ClearData(iMachineNumber, iDataFlag))
            {
                axCZKEM1.RefreshData(iMachineNumber);//the data in the device should be refreshed
                MessageBox.Show("Clear all the fingerprint templates!", "Success");
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
            }
            Cursor = Cursors.Default;
        }


        private void btnClearDataUserInfo_Click(object sender, EventArgs e)
        {
            if (bIsConnected == false)
            {
                MessageBox.Show("Please connect the device first!", "Error");
                return;
            }
            int idwErrorCode = 0;

            int iDataFlag = 5;

            Cursor = Cursors.WaitCursor;
            if (axCZKEM1.ClearData(iMachineNumber, iDataFlag))
            {
                axCZKEM1.RefreshData(iMachineNumber);//the data in the device should be refreshed
                MessageBox.Show("Clear all the UserInfo data!", "Success");
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
            }
            Cursor = Cursors.Default;
        }

        private void btnDeleteEnrollData_Click(object sender, EventArgs e)
        {
            if (bIsConnected == false)
            {
                MessageBox.Show("Please connect the device first!", "Error");
                return;
            }

            if (cbUserIDDE.Text.Trim() == "" || cbBackupDE.Text.Trim() == "")
            {
                MessageBox.Show("Please input the UserID and BackupNumber first!", "Error");
                return;
            }
            int idwErrorCode = 0;

            string sUserID = cbUserIDDE.Text.Trim();
            int iBackupNumber = Convert.ToInt32(cbBackupDE.Text.Trim());

            Cursor = Cursors.WaitCursor;
            if (axCZKEM1.SSR_DeleteEnrollData(iMachineNumber, sUserID, iBackupNumber))
            {
                axCZKEM1.RefreshData(iMachineNumber);//the data in the device should be refreshed
                MessageBox.Show("DeleteEnrollData,UserID=" + sUserID + " BackupNumber=" + iBackupNumber.ToString(), "Success");
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
            }
            Cursor = Cursors.Default;
        }

        //Clear all the administrator privilege(not clear the administrators themselves)// In case user have password
        private void btnClearAdministrators_Click(object sender, EventArgs e)
        {
            if (bIsConnected == false)
            {
                MessageBox.Show("Please connect the device first", "Error");
                return;
            }
            int idwErrorCode = 0;

            Cursor = Cursors.WaitCursor;
            if (axCZKEM1.ClearAdministrators(iMachineNumber))
            {
                axCZKEM1.RefreshData(iMachineNumber);//the data in the device should be refreshed
                MessageBox.Show("Successfully clear administrator privilege from teiminal!", "Success");
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
            }
            Cursor = Cursors.Default;
        }

        //Download users' face templates(in strings)(For TFT screen IFace series devices only)
        private void btnDownLoadFace_Click(object sender, EventArgs e)
        {
            if (bIsConnected == false)
            {
                MessageBox.Show("Please connect the device first!", "Error");
                return;
            }

            string sUserID = "";
            string sName = "";
            string sPassword = "";
            int iPrivilege = 0;
            bool bEnabled = false;

            int iFaceIndex = 50;//the only possible parameter value
            string sTmpData = "";
            int iLength = 0;

            lvFace.Items.Clear();
            lvFace.BeginUpdate();

            Cursor = Cursors.WaitCursor;
            axCZKEM1.EnableDevice(iMachineNumber, false);
            axCZKEM1.ReadAllUserID(iMachineNumber);//read all the user information to the memory

            while (axCZKEM1.SSR_GetAllUserInfo(iMachineNumber, out sUserID, out sName, out sPassword, out iPrivilege, out bEnabled))//get all the users' information from the memory
            {
                if (axCZKEM1.GetUserFaceStr(iMachineNumber, sUserID, iFaceIndex, ref sTmpData, ref iLength))//get the face templates from the memory
                {
                    ListViewItem list = new ListViewItem();
                    list.Text = sUserID;
                    list.SubItems.Add(sName);
                    list.SubItems.Add(sPassword);
                    list.SubItems.Add(iPrivilege.ToString());
                    list.SubItems.Add(iFaceIndex.ToString());
                    list.SubItems.Add(sTmpData);
                    list.SubItems.Add(iLength.ToString());
                    if (bEnabled == true)
                    {
                        list.SubItems.Add("true");
                    }
                    else
                    {
                        list.SubItems.Add("false");
                    }
                    lvFace.Items.Add(list);
                }
            }
            axCZKEM1.EnableDevice(iMachineNumber, true);
            lvFace.EndUpdate();
            Cursor = Cursors.Default;
        }

        private void btnDownloadFace_SQL_Click(object sender, EventArgs e)
        {
            lvFace.Items.Clear();

            try
            {
                string connetionString;
                SqlConnection cnn;
                SqlCommand cmd;
                connetionString = @"Data Source=192.168.88.141;Initial Catalog=CarService;User ID=sa;Password=sa0816812178";
                cnn = new SqlConnection(connetionString);

                cmd = new SqlCommand("select * from EmpFace", cnn);

                string selectquery = "select * from EmpFace";

                SqlDataAdapter adpt = new SqlDataAdapter(selectquery, cnn);

                DataTable table = new DataTable();

                adpt.Fill(table);

                var empJoin = (from TBEmp in table.AsEnumerable()
                              select new
                              {
                                  EmpNum = TBEmp.Field<string>("EmployeeNumber"),
                                  EmpName = TBEmp.Field<string>("EmployeeName")
                              });

                int numRows = 0;

                foreach (var item in empJoin)
                {
                    Console.WriteLine(String.Format("EmpID = {0}, EmpName = {1}", 
                        item.EmpNum, item.EmpName));
                    numRows++;

                    //set demo value
                    string sUserID = item.EmpNum;
                    string sName = item.EmpName;
                    string sPassword = "";
                    int iPrivilege = 0;
                    bool bEnabled = true;

                    int iFaceIndex = 0;
                    string sTmpData = "";
                    int iLength = 0;

                    //add to list table
                    ListViewItem list = new ListViewItem();
                    list.Text = sUserID;
                    list.SubItems.Add(sName);
                    list.SubItems.Add(sPassword);
                    list.SubItems.Add(iPrivilege.ToString());
                    list.SubItems.Add(iFaceIndex.ToString());
                    list.SubItems.Add(sTmpData);
                    list.SubItems.Add(iLength.ToString());

                    if (bEnabled == true)
                    {
                        list.SubItems.Add("true");
                    }
                    else
                    {
                        list.SubItems.Add("false");
                    }
                    lvFace.Items.Add(list);
                }
            }
            catch (SystemException ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnUploadFace_Click(object sender, EventArgs e)
        {
            if (bIsConnected == false)
            {
                MessageBox.Show("Please connect the device first!", "Error");
                return;
            }
            int idwErrorCode = 0;

            string sUserID = "";
            string sName = "";
            int iFaceIndex = 0;
            string sTmpData = "";
            int iLength = 0;
            int iPrivilege = 0;
            string sPassword = "";
            string sEnabled = "";
            bool bEnabled = false;

            Cursor = Cursors.WaitCursor;
            axCZKEM1.EnableDevice(iMachineNumber, false);
            for (int i = 0; i < lvFace.Items.Count; i++)
            {
                sUserID = lvFace.Items[i].SubItems[0].Text;
                sName = lvFace.Items[i].SubItems[1].Text;
                sPassword = lvFace.Items[i].SubItems[2].Text;
                iPrivilege = Convert.ToInt32(lvFace.Items[i].SubItems[3].Text);
                iFaceIndex = Convert.ToInt32(lvFace.Items[i].SubItems[4].Text);
                sTmpData = lvFace.Items[i].SubItems[5].Text;
                iLength = Convert.ToInt32(lvFace.Items[i].SubItems[6].Text);
                if (sEnabled == "true")
                {
                    bEnabled = true;
                }
                else
                {
                    bEnabled = false;
                }

                if (axCZKEM1.SSR_SetUserInfo(iMachineNumber, sUserID, sName, sPassword, iPrivilege, bEnabled))//face templates are part of users' information
                {
                    axCZKEM1.SetUserFaceStr(iMachineNumber, sUserID, iFaceIndex, sTmpData, iLength);//upload face templates information to the device
                }
                else
                {
                    axCZKEM1.GetLastError(ref idwErrorCode);
                    MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
                    Cursor = Cursors.Default;
                    axCZKEM1.EnableDevice(iMachineNumber, true);
                    return;
                }
            }

            axCZKEM1.RefreshData(iMachineNumber);//the data in the device should be refreshed
            Cursor = Cursors.Default;
            axCZKEM1.EnableDevice(iMachineNumber, true);
            MessageBox.Show("Successfully Upload the face templates, " + "total:" + lvFace.Items.Count.ToString(), "Success");
        }

        private void btnUploadFace_SQL_Click(object sender, EventArgs e)
        {
            if (lvFace.Items.Count > 0) //check have table row?
            {
                var list = new List<bool>();
                //begin upload
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=192.168.88.141;Initial Catalog=CarService;User ID=sa;Password=sa0816812178";
                cnn = new SqlConnection(connetionString);

                for (int r = 1; r <= lvFace.Items.Count; r++) // read all (1 by 1)
                {
                    if (lvFace.Items[r - 1].SubItems[5].Text == "") // check have face data?
                    {
                        list.Add(false);//no finger data
                    }
                    else
                    {
                        cnn.Open();
                        string selectquery = "select * from EmpFace where FaceCode = '" + lvFace.Items[r - 1].SubItems[5].Text + "'";
                        SqlCommand cmd = new SqlCommand(selectquery, cnn);
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();

                        if (reader1.Read())// found duplicate = not upload to SQL dbo.EmpFace
                        {
                            MessageBox.Show("face already exist");
                            cnn.Close();
                            return;
                        }
                        else
                        {
                            list.Add(true);
                        }
                    }
                    cnn.Close();
                }

                if (!list.Contains(true))//all row no face data
                {
                    MessageBox.Show("All data no FaceImage!", "Error");
                }
                else if (!list.Contains(false))//all row have face data
                {
                    MessageBox.Show("Upload FaceImage!", "Error");

                    cnn.Open();

                    for (int r = 1; r <= lvFace.Items.Count; r++) // upload to sever SQL (1 by 1)
                    {
                        //String query = @"DECLARE @FingerNumber INT;" + "SELECT @FingerNumber  =  MAX(FingerNumber)+1 from EmpFinger ";//col 1 in SQL (dbo.EmpFinger)
                        String query = "INSERT INTO dbo.EmpFace (EmployeeNumber,EmployeeName,FaceIndex,FaceCode,FaceLenght) ";
                        query += "VALUES (@EmployeeNumber,@EmployeeName, @FaceIndex,@FaceCode,@FaceLenght)";
                        SqlCommand uploadFace = new SqlCommand(query, cnn);

                        uploadFace.Parameters.AddWithValue("@EmployeeNumber", lvFace.Items[r - 1].SubItems[0].Text);//col 1 in SQL (dbo.EmpFace)
                        uploadFace.Parameters.AddWithValue("@EmployeeName", lvFace.Items[r - 1].SubItems[1].Text);//col 2 in SQL (dbo.EmpFace)
                        uploadFace.Parameters.AddWithValue("@FaceIndex", lvFace.Items[r - 1].SubItems[4].Text);//col 3 in SQL (dbo.EmpFace)
                        uploadFace.Parameters.AddWithValue("FaceCode", lvFace.Items[r - 1].SubItems[5].Text);//col 4 in SQL (dbo.EmpFace)
                        uploadFace.Parameters.AddWithValue("FaceLenght", lvFace.Items[r - 1].SubItems[6].Text);//col 5 in SQL (dbo.EmpFace)
                        uploadFace.ExecuteNonQuery();
                    }
                    cnn.Close();
                }
                else//have some
                    MessageBox.Show("not at all!", "Error");
            }
            else
                MessageBox.Show("There is no data to upload!", "Error");
            return;
        }

        //Delete a certain user's face template according to its id
        private void btnDelUserFace_Click(object sender, EventArgs e)
        {
            if (bIsConnected == false)
            {
                MessageBox.Show("Please connect the device first!", "Error");
                return;
            }

            if (cbUserID3.Text.Trim() == "")
            {
                MessageBox.Show("Please input the UserID first!", "Error");
                return;
            }
            int idwErrorCode = 0;

            string sUserID = cbUserID3.Text.Trim();
            int iFaceIndex = 50;

            Cursor = Cursors.WaitCursor;
            if (axCZKEM1.DelUserFace(iMachineNumber, sUserID, iFaceIndex))
            {
                axCZKEM1.RefreshData(iMachineNumber);
                MessageBox.Show("DelUserFace,UserID=" + sUserID, "Success");
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
            }
            Cursor = Cursors.Default;

        }

        private void btnGetUserFace_Click(object sender, EventArgs e)
        {
            if (bIsConnected == false)
            {
                MessageBox.Show("Please connect the device first!", "Error");
                return;
            }

            if (cbUserID3.Text.Trim() == "")
            {
                MessageBox.Show("Please input the UserID first!", "Error");
                return;
            }
            int idwErrorCode = 0;

            string sUserID = cbUserID3.Text.Trim();
            int iFaceIndex = 50;//the only possible parameter value
            int iLength = 128 * 1024;//initialize the length(cannot be zero)
            byte[] byTmpData = new byte[iLength];

            Cursor = Cursors.WaitCursor;
            axCZKEM1.EnableDevice(iMachineNumber, false);

            if (axCZKEM1.GetUserFace(iMachineNumber, sUserID, iFaceIndex, ref byTmpData[0], ref iLength))
            {
                //Here you can manage the information of the face templates according to your request.(for example,you can sava them to the database)
                MessageBox.Show("GetUserFace,the  length of the bytes array byTmpData is " + iLength.ToString(), "Success");
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
            }

            axCZKEM1.EnableDevice(iMachineNumber, true);
            Cursor = Cursors.Default;
        }

        bool bAddControl = true;
        private void UserIDTimer_Tick(object sender, EventArgs e)
        {
            if (bIsConnected == false)
            {
                cbUserIDDE.Items.Clear();
                cbUserIDTmp.Items.Clear();
                bAddControl = true;
                return;
            }
            else
            {
                if (bAddControl == true)
                {
                    string sEnrollNumber = "";
                    string sName = "";
                    string sPassword = "";
                    int iPrivilege = 0;
                    bool bEnabled = false;

                    axCZKEM1.EnableDevice(iMachineNumber, false);
                    axCZKEM1.ReadAllUserID(iMachineNumber);//read all the user information to the memory
                    while (axCZKEM1.SSR_GetAllUserInfo(iMachineNumber, out sEnrollNumber, out sName, out sPassword, out iPrivilege, out bEnabled))
                    {
                        cbUserIDDE.Items.Add(sEnrollNumber);
                        cbUserIDTmp.Items.Add(sEnrollNumber);
                    }
                    bAddControl = false;
                    axCZKEM1.EnableDevice(iMachineNumber, true);
                }
                return;
            }
        }
        #endregion


        #region RealTime Events

        //When you place your finger on sensor of the device,this event will be triggered
        private void axCZKEM1_OnFinger()
        {
            lbRTShow.Items.Add("RTEvent OnFinger Has been Triggered");
        }

        //After you have placed your finger on the sensor(or swipe your card to the device),this event will be triggered.
        //If you passes the verification,the returned value userid will be the user enrollnumber,or else the value will be -1;
        private void axCZKEM1_OnVerify(int iUserID)
        {
            lbRTShow.Items.Add("RTEvent OnVerify Has been Triggered,Verifying...");
            if (iUserID != -1)
            {
                lbRTShow.Items.Add("Verified OK,the UserID is " + iUserID.ToString());
            }
            else
            {
                lbRTShow.Items.Add("Verified Failed... ");
            }
        }

        //If your fingerprint(or your card) passes the verification,this event will be triggered
        private void axCZKEM1_OnAttTransactionEx(string sEnrollNumber, int iIsInValid, int iAttState, int iVerifyMethod, int iYear, int iMonth, int iDay, int iHour, int iMinute, int iSecond, int iWorkCode)
        {
            lbRTShow.Items.Add("RTEvent OnAttTrasactionEx Has been Triggered,Verified OK");
            lbRTShow.Items.Add("...UserID:" + sEnrollNumber);
            lbRTShow.Items.Add("...isInvalid:" + iIsInValid.ToString());
            lbRTShow.Items.Add("...attState:" + iAttState.ToString());
            lbRTShow.Items.Add("...VerifyMethod:" + iVerifyMethod.ToString());
            lbRTShow.Items.Add("...Workcode:" + iWorkCode.ToString());//the difference between the event OnAttTransaction and OnAttTransactionEx
            lbRTShow.Items.Add("...Time:" + iYear.ToString() + "-" + iMonth.ToString() + "-" + iDay.ToString() + " " + iHour.ToString() + ":" + iMinute.ToString() + ":" + iSecond.ToString());

            //update log here
            MessageBox.Show("Login Success!", "Alert");

            //begin upload
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=192.168.88.141;Initial Catalog=CarService;User ID=sa;Password=sa0816812178";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            String query = "INSERT INTO dbo.Log_ZKTeco (EmployeeNumber,EmployeeName,VerifyMethod,TimeStamp) ";
            query += "VALUES (@EmployeeNumber,@EmployeeName, @VerifyMethod,@TimeStamp)";
            SqlCommand uploadLog = new SqlCommand(query, cnn);

            uploadLog.Parameters.AddWithValue("@EmployeeNumber", sEnrollNumber);//col 1 in SQL (dbo.Log_ZKTeco)
            uploadLog.Parameters.AddWithValue("@VerifyMethod", iVerifyMethod.ToString());//col 3 in SQL (dbo.Log_ZKTeco)
            uploadLog.Parameters.AddWithValue("@TimeStamp", iYear.ToString() + "-" 
                + iMonth.ToString() + "-" + iDay.ToString() + " " + iHour.ToString() + ":" + iMinute.ToString() 
                + ":" + iSecond.ToString());//col 4 in SQL (dbo.Log_ZKTeco)

            uploadLog.ExecuteNonQuery();

            cnn.Close();
        }

        //When you have enrolled your finger,this event will be triggered and return the quality of the fingerprint you have enrolled
        private void axCZKEM1_OnFingerFeature(int iScore)
        {
            if (iScore < 0)
            {
                lbRTShow.Items.Add("The quality of your fingerprint is poor");
            }
            else
            {
                lbRTShow.Items.Add("RTEvent OnFingerFeature Has been Triggered...Score:　" + iScore.ToString());
            }
        }

        //When you are enrolling your finger,this event will be triggered.(The event can only be triggered by TFT screen devices)
        private void axCZKEM1_OnEnrollFingerEx(string sEnrollNumber, int iFingerIndex, int iActionResult, int iTemplateLength)
        {
            if (iActionResult == 0)
            {
                lbRTShow.Items.Add("RTEvent OnEnrollFigerEx Has been Triggered....");
                lbRTShow.Items.Add(".....UserID: " + sEnrollNumber + " Index: " + iFingerIndex.ToString() + " tmpLen: " + iTemplateLength.ToString());
            }
            else
            {
                lbRTShow.Items.Add("RTEvent OnEnrollFigerEx Has been Triggered Error,actionResult=" + iActionResult.ToString());
            }
        }

        //When you have deleted one one fingerprint template,this event will be triggered.
        private void axCZKEM1_OnDeleteTemplate(int iEnrollNumber, int iFingerIndex)
        {
            lbRTShow.Items.Add("RTEvent OnDeleteTemplate Has been Triggered...");
            lbRTShow.Items.Add("...UserID=" + iEnrollNumber.ToString() + " FingerIndex=" + iFingerIndex.ToString());
        }

        //When you have enrolled a new user,this event will be triggered.
        private void axCZKEM1_OnNewUser(int iEnrollNumber)
        {
            lbRTShow.Items.Add("RTEvent OnNewUser Has been Triggered...");
            lbRTShow.Items.Add("...NewUserID=" + iEnrollNumber.ToString());
        }

        //When you swipe a card to the device, this event will be triggered to show you the card number.
        private void axCZKEM1_OnHIDNum(int iCardNumber)
        {
            lbRTShow.Items.Add("RTEvent OnHIDNum Has been Triggered...");
            lbRTShow.Items.Add("...Cardnumber=" + iCardNumber.ToString());
        }

        //When the dismantling machine or duress alarm occurs, trigger this event.
        private void axCZKEM1_OnAlarm(int iAlarmType, int iEnrollNumber, int iVerified)
        {
            lbRTShow.Items.Add("RTEvnet OnAlarm Has been Triggered...");
            lbRTShow.Items.Add("...AlarmType=" + iAlarmType.ToString());
            lbRTShow.Items.Add("...EnrollNumber=" + iEnrollNumber.ToString());
            lbRTShow.Items.Add("...Verified=" + iVerified.ToString());
        }

        //Door sensor event
        private void axCZKEM1_OnDoor(int iEventType)
        {
            lbRTShow.Items.Add("RTEvent Ondoor Has been Triggered...");
            lbRTShow.Items.Add("...EventType=" + iEventType.ToString());
        }

        //When you have emptyed the Mifare card,this event will be triggered.
        private void axCZKEM1_OnEmptyCard(int iActionResult)
        {
            lbRTShow.Items.Add("RTEvent OnEmptyCard Has been Triggered...");
            if (iActionResult == 0)
            {
                lbRTShow.Items.Add("...Empty Mifare Card OK");
            }
            else
            {
                lbRTShow.Items.Add("...Empty Failed");
            }
        }

        //When you have written into the Mifare card ,this event will be triggered.
        private void axCZKEM1_OnWriteCard(int iEnrollNumber, int iActionResult, int iLength)
        {
            lbRTShow.Items.Add("RTEvent OnWriteCard Has been Triggered...");
            if (iActionResult == 0)
            {
                lbRTShow.Items.Add("...Write Mifare Card OK");
                lbRTShow.Items.Add("...EnrollNumber=" + iEnrollNumber.ToString());
                lbRTShow.Items.Add("...TmpLength=" + iLength.ToString());
            }
            else
            {
                lbRTShow.Items.Add("...Write Failed");
            }
        }

        //After function GetRTLog() is called ,RealTime Events will be triggered. 
        //When you are using these two functions, it will request data from the device forwardly.
        private void rtTimer_Tick(object sender, EventArgs e)
        {
            
            if (axCZKEM1.ReadRTLog(iMachineNumber))
            {
                while (axCZKEM1.GetRTLog(iMachineNumber))
                {
                    ;
                }
            }
        }
        #endregion

        
    }
}