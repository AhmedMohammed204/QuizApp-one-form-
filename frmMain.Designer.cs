namespace QuizApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tcScreens = new System.Windows.Forms.TabControl();
            this.tpProfile = new System.Windows.Forms.TabPage();
            this.tcProfile = new System.Windows.Forms.TabControl();
            this.tbLogin = new System.Windows.Forms.TabPage();
            this.lblLoginWrongMessage = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pbPasswordKey = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.tpShowProfile = new System.Windows.Forms.TabPage();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.gbQuizInformation = new System.Windows.Forms.GroupBox();
            this.lblRightAnswers = new System.Windows.Forms.Label();
            this.lblTotalQuestions = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tpEditProfile = new System.Windows.Forms.TabPage();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnSaveEditProfile = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tpQuizes = new System.Windows.Forms.TabPage();
            this.tcQuizesContatiner = new System.Windows.Forms.TabControl();
            this.tpMathQuiz = new System.Windows.Forms.TabPage();
            this.btnBackToQuizesScreen = new System.Windows.Forms.Button();
            this.lblMathTimer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.lblMathAfterAnswer = new System.Windows.Forms.Label();
            this.btnMathOptionD = new System.Windows.Forms.Button();
            this.btnMathOptionB = new System.Windows.Forms.Button();
            this.btnMathOptionC = new System.Windows.Forms.Button();
            this.btnMathOptionA = new System.Windows.Forms.Button();
            this.lblMathQuestion = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbMathOptionD = new System.Windows.Forms.PictureBox();
            this.pbMathOptionB = new System.Windows.Forms.PictureBox();
            this.pbMathOptionC = new System.Windows.Forms.PictureBox();
            this.pbMathOptionA = new System.Windows.Forms.PictureBox();
            this.pbMathQuestion = new System.Windows.Forms.PictureBox();
            this.tpQuizesList = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTimeForEachQuestion = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMathcQuiz = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnQuizes = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timerMath = new System.Windows.Forms.Timer(this.components);
            this.imageListLogin = new System.Windows.Forms.ImageList(this.components);
            this.tcScreens.SuspendLayout();
            this.tpProfile.SuspendLayout();
            this.tcProfile.SuspendLayout();
            this.tbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPasswordKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tpShowProfile.SuspendLayout();
            this.gbQuizInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpEditProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tpQuizes.SuspendLayout();
            this.tcQuizesContatiner.SuspendLayout();
            this.tpMathQuiz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMathOptionD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMathOptionB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMathOptionC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMathOptionA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMathQuestion)).BeginInit();
            this.tpQuizesList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcScreens
            // 
            this.tcScreens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcScreens.Controls.Add(this.tpProfile);
            this.tcScreens.Controls.Add(this.tpQuizes);
            this.tcScreens.Location = new System.Drawing.Point(23, -21);
            this.tcScreens.Multiline = true;
            this.tcScreens.Name = "tcScreens";
            this.tcScreens.SelectedIndex = 0;
            this.tcScreens.Size = new System.Drawing.Size(863, 392);
            this.tcScreens.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcScreens.TabIndex = 0;
            // 
            // tpProfile
            // 
            this.tpProfile.Controls.Add(this.tcProfile);
            this.tpProfile.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpProfile.Location = new System.Drawing.Point(4, 22);
            this.tpProfile.Name = "tpProfile";
            this.tpProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tpProfile.Size = new System.Drawing.Size(855, 366);
            this.tpProfile.TabIndex = 0;
            this.tpProfile.Text = "Profile";
            this.tpProfile.UseVisualStyleBackColor = true;
            // 
            // tcProfile
            // 
            this.tcProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcProfile.Controls.Add(this.tbLogin);
            this.tcProfile.Controls.Add(this.tpShowProfile);
            this.tcProfile.Controls.Add(this.tpEditProfile);
            this.tcProfile.Location = new System.Drawing.Point(6, -26);
            this.tcProfile.Multiline = true;
            this.tcProfile.Name = "tcProfile";
            this.tcProfile.SelectedIndex = 0;
            this.tcProfile.Size = new System.Drawing.Size(843, 386);
            this.tcProfile.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcProfile.TabIndex = 6;
            // 
            // tbLogin
            // 
            this.tbLogin.Controls.Add(this.lblLoginWrongMessage);
            this.tbLogin.Controls.Add(this.btnLogin);
            this.tbLogin.Controls.Add(this.pbPasswordKey);
            this.tbLogin.Controls.Add(this.pictureBox5);
            this.tbLogin.Controls.Add(this.txtLoginPassword);
            this.tbLogin.Controls.Add(this.pictureBox4);
            this.tbLogin.Controls.Add(this.txtLoginUsername);
            this.tbLogin.Location = new System.Drawing.Point(4, 24);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(835, 358);
            this.tbLogin.TabIndex = 2;
            this.tbLogin.Text = "Login";
            this.tbLogin.UseVisualStyleBackColor = true;
            // 
            // lblLoginWrongMessage
            // 
            this.lblLoginWrongMessage.AutoSize = true;
            this.lblLoginWrongMessage.ForeColor = System.Drawing.Color.Tomato;
            this.lblLoginWrongMessage.Location = new System.Drawing.Point(321, 229);
            this.lblLoginWrongMessage.Name = "lblLoginWrongMessage";
            this.lblLoginWrongMessage.Size = new System.Drawing.Size(169, 15);
            this.lblLoginWrongMessage.TabIndex = 5;
            this.lblLoginWrongMessage.Text = "Wrong username or password !";
            this.lblLoginWrongMessage.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.DimGray;
            this.btnLogin.Location = new System.Drawing.Point(336, 274);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(139, 51);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pbPasswordKey
            // 
            this.pbPasswordKey.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbPasswordKey.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbPasswordKey.Image = global::QuizApp.Properties.Resources.hide;
            this.pbPasswordKey.Location = new System.Drawing.Point(558, 156);
            this.pbPasswordKey.Name = "pbPasswordKey";
            this.pbPasswordKey.Size = new System.Drawing.Size(40, 36);
            this.pbPasswordKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPasswordKey.TabIndex = 4;
            this.pbPasswordKey.TabStop = false;
            this.pbPasswordKey.Click += new System.EventHandler(this.pbPasswordKey_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox5.Image = global::QuizApp.Properties.Resources._lock;
            this.pictureBox5.Location = new System.Drawing.Point(199, 151);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginPassword.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPassword.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtLoginPassword.Location = new System.Drawing.Point(262, 156);
            this.txtLoginPassword.MaxLength = 30;
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(336, 36);
            this.txtLoginPassword.TabIndex = 1;
            this.txtLoginPassword.Tag = "12345";
            this.txtLoginPassword.Enter += new System.EventHandler(this.txtLogin_Enter);
            this.txtLoginPassword.Leave += new System.EventHandler(this.txtLogin_Leave);
            this.txtLoginPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox4.Image = global::QuizApp.Properties.Resources.user1;
            this.pictureBox4.Location = new System.Drawing.Point(205, 79);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLoginUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginUsername.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUsername.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtLoginUsername.Location = new System.Drawing.Point(262, 79);
            this.txtLoginUsername.MaxLength = 30;
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(336, 36);
            this.txtLoginUsername.TabIndex = 0;
            this.txtLoginUsername.Tag = "Ahmed";
            this.txtLoginUsername.Enter += new System.EventHandler(this.txtLogin_Enter);
            this.txtLoginUsername.Leave += new System.EventHandler(this.txtLogin_Leave);
            this.txtLoginUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // tpShowProfile
            // 
            this.tpShowProfile.Controls.Add(this.btnEditProfile);
            this.tpShowProfile.Controls.Add(this.lblLastName);
            this.tpShowProfile.Controls.Add(this.lblFirstName);
            this.tpShowProfile.Controls.Add(this.gbQuizInformation);
            this.tpShowProfile.Controls.Add(this.lblUsername);
            this.tpShowProfile.Controls.Add(this.label2);
            this.tpShowProfile.Controls.Add(this.label1);
            this.tpShowProfile.Controls.Add(this.pictureBox1);
            this.tpShowProfile.Location = new System.Drawing.Point(4, 24);
            this.tpShowProfile.Name = "tpShowProfile";
            this.tpShowProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tpShowProfile.Size = new System.Drawing.Size(835, 358);
            this.tpShowProfile.TabIndex = 0;
            this.tpShowProfile.Text = "tabPage1";
            this.tpShowProfile.UseVisualStyleBackColor = true;
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditProfile.BackColor = System.Drawing.Color.White;
            this.btnEditProfile.FlatAppearance.BorderSize = 2;
            this.btnEditProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnEditProfile.Location = new System.Drawing.Point(339, 305);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(123, 37);
            this.btnEditProfile.TabIndex = 3;
            this.btnEditProfile.Text = "Edit";
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblLastName.Location = new System.Drawing.Point(148, 74);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(112, 28);
            this.lblLastName.TabIndex = 13;
            this.lblLastName.Text = "Mohamed";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblFirstName.Location = new System.Drawing.Point(148, 28);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 28);
            this.lblFirstName.TabIndex = 12;
            this.lblFirstName.Text = "Ahmed";
            // 
            // gbQuizInformation
            // 
            this.gbQuizInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbQuizInformation.Controls.Add(this.lblRightAnswers);
            this.gbQuizInformation.Controls.Add(this.lblTotalQuestions);
            this.gbQuizInformation.Controls.Add(this.label5);
            this.gbQuizInformation.Controls.Add(this.label4);
            this.gbQuizInformation.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQuizInformation.Location = new System.Drawing.Point(397, 24);
            this.gbQuizInformation.Name = "gbQuizInformation";
            this.gbQuizInformation.Size = new System.Drawing.Size(200, 115);
            this.gbQuizInformation.TabIndex = 11;
            this.gbQuizInformation.TabStop = false;
            this.gbQuizInformation.Text = "Quiz Information";
            // 
            // lblRightAnswers
            // 
            this.lblRightAnswers.AutoSize = true;
            this.lblRightAnswers.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightAnswers.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblRightAnswers.Location = new System.Drawing.Point(112, 77);
            this.lblRightAnswers.Name = "lblRightAnswers";
            this.lblRightAnswers.Size = new System.Drawing.Size(22, 17);
            this.lblRightAnswers.TabIndex = 15;
            this.lblRightAnswers.Text = "56";
            // 
            // lblTotalQuestions
            // 
            this.lblTotalQuestions.AutoSize = true;
            this.lblTotalQuestions.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQuestions.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblTotalQuestions.Location = new System.Drawing.Point(122, 31);
            this.lblTotalQuestions.Name = "lblTotalQuestions";
            this.lblTotalQuestions.Size = new System.Drawing.Size(29, 17);
            this.lblTotalQuestions.TabIndex = 14;
            this.lblTotalQuestions.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Right Answers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Questions:";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(649, 214);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(115, 25);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "@Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::QuizApp.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(603, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tpEditProfile
            // 
            this.tpEditProfile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpEditProfile.Controls.Add(this.txtUsername);
            this.tpEditProfile.Controls.Add(this.txtLastName);
            this.tpEditProfile.Controls.Add(this.txtFirstName);
            this.tpEditProfile.Controls.Add(this.btnSaveEditProfile);
            this.tpEditProfile.Controls.Add(this.label11);
            this.tpEditProfile.Controls.Add(this.label12);
            this.tpEditProfile.Controls.Add(this.label13);
            this.tpEditProfile.Controls.Add(this.pictureBox2);
            this.tpEditProfile.Location = new System.Drawing.Point(4, 24);
            this.tpEditProfile.Name = "tpEditProfile";
            this.tpEditProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tpEditProfile.Size = new System.Drawing.Size(835, 358);
            this.tpEditProfile.TabIndex = 1;
            this.tpEditProfile.Text = "tabPage2";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtUsername.Location = new System.Drawing.Point(675, 212);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(136, 18);
            this.txtUsername.TabIndex = 23;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtLastName.Location = new System.Drawing.Point(143, 83);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(145, 18);
            this.txtLastName.TabIndex = 22;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtFirstName.Location = new System.Drawing.Point(143, 37);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(145, 18);
            this.txtFirstName.TabIndex = 21;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // btnSaveEditProfile
            // 
            this.btnSaveEditProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveEditProfile.BackColor = System.Drawing.Color.White;
            this.btnSaveEditProfile.FlatAppearance.BorderSize = 2;
            this.btnSaveEditProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaveEditProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaveEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEditProfile.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEditProfile.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnSaveEditProfile.Location = new System.Drawing.Point(341, 315);
            this.btnSaveEditProfile.Name = "btnSaveEditProfile";
            this.btnSaveEditProfile.Size = new System.Drawing.Size(123, 37);
            this.btnSaveEditProfile.TabIndex = 14;
            this.btnSaveEditProfile.Text = "Save";
            this.btnSaveEditProfile.UseVisualStyleBackColor = false;
            this.btnSaveEditProfile.Click += new System.EventHandler(this.btnSaveEditProfile_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label11.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(554, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "@Username";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 28);
            this.label12.TabIndex = 17;
            this.label12.Text = "Last Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 28);
            this.label13.TabIndex = 16;
            this.label13.Text = "First Name:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::QuizApp.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(597, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 159);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // tpQuizes
            // 
            this.tpQuizes.Controls.Add(this.tcQuizesContatiner);
            this.tpQuizes.Location = new System.Drawing.Point(4, 22);
            this.tpQuizes.Name = "tpQuizes";
            this.tpQuizes.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuizes.Size = new System.Drawing.Size(855, 366);
            this.tpQuizes.TabIndex = 1;
            this.tpQuizes.Text = "Quizes";
            this.tpQuizes.UseVisualStyleBackColor = true;
            // 
            // tcQuizesContatiner
            // 
            this.tcQuizesContatiner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcQuizesContatiner.Controls.Add(this.tpQuizesList);
            this.tcQuizesContatiner.Controls.Add(this.tpMathQuiz);
            this.tcQuizesContatiner.Location = new System.Drawing.Point(-4, -22);
            this.tcQuizesContatiner.Name = "tcQuizesContatiner";
            this.tcQuizesContatiner.SelectedIndex = 0;
            this.tcQuizesContatiner.Size = new System.Drawing.Size(863, 392);
            this.tcQuizesContatiner.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcQuizesContatiner.TabIndex = 0;
            // 
            // tpMathQuiz
            // 
            this.tpMathQuiz.Controls.Add(this.btnBackToQuizesScreen);
            this.tpMathQuiz.Controls.Add(this.lblMathTimer);
            this.tpMathQuiz.Controls.Add(this.label3);
            this.tpMathQuiz.Controls.Add(this.btnNextQuestion);
            this.tpMathQuiz.Controls.Add(this.lblMathAfterAnswer);
            this.tpMathQuiz.Controls.Add(this.btnMathOptionD);
            this.tpMathQuiz.Controls.Add(this.btnMathOptionB);
            this.tpMathQuiz.Controls.Add(this.btnMathOptionC);
            this.tpMathQuiz.Controls.Add(this.btnMathOptionA);
            this.tpMathQuiz.Controls.Add(this.lblMathQuestion);
            this.tpMathQuiz.Controls.Add(this.pictureBox3);
            this.tpMathQuiz.Controls.Add(this.pbMathOptionD);
            this.tpMathQuiz.Controls.Add(this.pbMathOptionB);
            this.tpMathQuiz.Controls.Add(this.pbMathOptionC);
            this.tpMathQuiz.Controls.Add(this.pbMathOptionA);
            this.tpMathQuiz.Controls.Add(this.pbMathQuestion);
            this.tpMathQuiz.Location = new System.Drawing.Point(4, 22);
            this.tpMathQuiz.Name = "tpMathQuiz";
            this.tpMathQuiz.Padding = new System.Windows.Forms.Padding(3);
            this.tpMathQuiz.Size = new System.Drawing.Size(855, 366);
            this.tpMathQuiz.TabIndex = 1;
            this.tpMathQuiz.Text = "Math Quiz";
            this.tpMathQuiz.UseVisualStyleBackColor = true;
            // 
            // btnBackToQuizesScreen
            // 
            this.btnBackToQuizesScreen.BackColor = System.Drawing.Color.White;
            this.btnBackToQuizesScreen.FlatAppearance.BorderSize = 2;
            this.btnBackToQuizesScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBackToQuizesScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToQuizesScreen.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToQuizesScreen.ForeColor = System.Drawing.Color.DimGray;
            this.btnBackToQuizesScreen.Location = new System.Drawing.Point(6, 3);
            this.btnBackToQuizesScreen.Name = "btnBackToQuizesScreen";
            this.btnBackToQuizesScreen.Size = new System.Drawing.Size(84, 35);
            this.btnBackToQuizesScreen.TabIndex = 16;
            this.btnBackToQuizesScreen.Text = "Back";
            this.btnBackToQuizesScreen.UseVisualStyleBackColor = false;
            this.btnBackToQuizesScreen.Click += new System.EventHandler(this.btnBackToQuizesScreen_Click);
            // 
            // lblMathTimer
            // 
            this.lblMathTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMathTimer.AutoSize = true;
            this.lblMathTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblMathTimer.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMathTimer.ForeColor = System.Drawing.Color.Black;
            this.lblMathTimer.Location = new System.Drawing.Point(800, 19);
            this.lblMathTimer.Name = "lblMathTimer";
            this.lblMathTimer.Size = new System.Drawing.Size(36, 27);
            this.lblMathTimer.TabIndex = 15;
            this.lblMathTimer.Text = "00";
            this.lblMathTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(369, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 27);
            this.label3.TabIndex = 14;
            this.label3.Text = "Math Game";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextQuestion.BackColor = System.Drawing.Color.White;
            this.btnNextQuestion.FlatAppearance.BorderSize = 2;
            this.btnNextQuestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextQuestion.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQuestion.ForeColor = System.Drawing.Color.DimGray;
            this.btnNextQuestion.Location = new System.Drawing.Point(572, 293);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(147, 51);
            this.btnNextQuestion.TabIndex = 3;
            this.btnNextQuestion.Text = "Next Question ->";
            this.btnNextQuestion.UseVisualStyleBackColor = false;
            this.btnNextQuestion.Visible = false;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // lblMathAfterAnswer
            // 
            this.lblMathAfterAnswer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMathAfterAnswer.BackColor = System.Drawing.Color.LightGreen;
            this.lblMathAfterAnswer.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMathAfterAnswer.ForeColor = System.Drawing.Color.Black;
            this.lblMathAfterAnswer.Location = new System.Drawing.Point(19, 283);
            this.lblMathAfterAnswer.Name = "lblMathAfterAnswer";
            this.lblMathAfterAnswer.Size = new System.Drawing.Size(523, 71);
            this.lblMathAfterAnswer.TabIndex = 12;
            this.lblMathAfterAnswer.Text = "Good!";
            this.lblMathAfterAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMathAfterAnswer.Visible = false;
            // 
            // btnMathOptionD
            // 
            this.btnMathOptionD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMathOptionD.BackColor = System.Drawing.Color.White;
            this.btnMathOptionD.FlatAppearance.BorderSize = 2;
            this.btnMathOptionD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMathOptionD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMathOptionD.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMathOptionD.ForeColor = System.Drawing.Color.DimGray;
            this.btnMathOptionD.Location = new System.Drawing.Point(466, 210);
            this.btnMathOptionD.Name = "btnMathOptionD";
            this.btnMathOptionD.Size = new System.Drawing.Size(307, 60);
            this.btnMathOptionD.TabIndex = 10;
            this.btnMathOptionD.Text = "Option D";
            this.btnMathOptionD.UseVisualStyleBackColor = false;
            this.btnMathOptionD.Click += new System.EventHandler(this.btnMathOption_Click);
            this.btnMathOptionD.MouseEnter += new System.EventHandler(this.btnMathOption_MouseEnter);
            this.btnMathOptionD.MouseLeave += new System.EventHandler(this.btnMathOption_MouseLeave);
            // 
            // btnMathOptionB
            // 
            this.btnMathOptionB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMathOptionB.BackColor = System.Drawing.Color.White;
            this.btnMathOptionB.FlatAppearance.BorderSize = 2;
            this.btnMathOptionB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMathOptionB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMathOptionB.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMathOptionB.ForeColor = System.Drawing.Color.DimGray;
            this.btnMathOptionB.Location = new System.Drawing.Point(466, 131);
            this.btnMathOptionB.Name = "btnMathOptionB";
            this.btnMathOptionB.Size = new System.Drawing.Size(307, 60);
            this.btnMathOptionB.TabIndex = 8;
            this.btnMathOptionB.Text = "Option B";
            this.btnMathOptionB.UseVisualStyleBackColor = false;
            this.btnMathOptionB.Click += new System.EventHandler(this.btnMathOption_Click);
            this.btnMathOptionB.MouseEnter += new System.EventHandler(this.btnMathOption_MouseEnter);
            this.btnMathOptionB.MouseLeave += new System.EventHandler(this.btnMathOption_MouseLeave);
            // 
            // btnMathOptionC
            // 
            this.btnMathOptionC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMathOptionC.BackColor = System.Drawing.Color.White;
            this.btnMathOptionC.FlatAppearance.BorderSize = 2;
            this.btnMathOptionC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMathOptionC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMathOptionC.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMathOptionC.ForeColor = System.Drawing.Color.DimGray;
            this.btnMathOptionC.Location = new System.Drawing.Point(78, 210);
            this.btnMathOptionC.Name = "btnMathOptionC";
            this.btnMathOptionC.Size = new System.Drawing.Size(307, 60);
            this.btnMathOptionC.TabIndex = 6;
            this.btnMathOptionC.Text = "Option C";
            this.btnMathOptionC.UseVisualStyleBackColor = false;
            this.btnMathOptionC.Click += new System.EventHandler(this.btnMathOption_Click);
            this.btnMathOptionC.MouseEnter += new System.EventHandler(this.btnMathOption_MouseEnter);
            this.btnMathOptionC.MouseLeave += new System.EventHandler(this.btnMathOption_MouseLeave);
            // 
            // btnMathOptionA
            // 
            this.btnMathOptionA.BackColor = System.Drawing.Color.White;
            this.btnMathOptionA.FlatAppearance.BorderSize = 2;
            this.btnMathOptionA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMathOptionA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMathOptionA.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMathOptionA.ForeColor = System.Drawing.Color.DimGray;
            this.btnMathOptionA.Location = new System.Drawing.Point(78, 131);
            this.btnMathOptionA.Name = "btnMathOptionA";
            this.btnMathOptionA.Size = new System.Drawing.Size(307, 60);
            this.btnMathOptionA.TabIndex = 3;
            this.btnMathOptionA.Text = "Option A";
            this.btnMathOptionA.UseVisualStyleBackColor = false;
            this.btnMathOptionA.Click += new System.EventHandler(this.btnMathOption_Click);
            this.btnMathOptionA.MouseEnter += new System.EventHandler(this.btnMathOption_MouseEnter);
            this.btnMathOptionA.MouseLeave += new System.EventHandler(this.btnMathOption_MouseLeave);
            // 
            // lblMathQuestion
            // 
            this.lblMathQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMathQuestion.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblMathQuestion.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMathQuestion.ForeColor = System.Drawing.Color.Black;
            this.lblMathQuestion.Location = new System.Drawing.Point(54, 41);
            this.lblMathQuestion.Name = "lblMathQuestion";
            this.lblMathQuestion.Size = new System.Drawing.Size(740, 71);
            this.lblMathQuestion.TabIndex = 0;
            this.lblMathQuestion.Text = "Num1 + Num2";
            this.lblMathQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LemonChiffon;
            this.pictureBox3.Image = global::QuizApp.Properties.Resources.math;
            this.pictureBox3.Location = new System.Drawing.Point(335, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pbMathOptionD
            // 
            this.pbMathOptionD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMathOptionD.BackColor = System.Drawing.Color.White;
            this.pbMathOptionD.Image = global::QuizApp.Properties.Resources.letter_d;
            this.pbMathOptionD.Location = new System.Drawing.Point(477, 221);
            this.pbMathOptionD.Name = "pbMathOptionD";
            this.pbMathOptionD.Size = new System.Drawing.Size(65, 40);
            this.pbMathOptionD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMathOptionD.TabIndex = 11;
            this.pbMathOptionD.TabStop = false;
            // 
            // pbMathOptionB
            // 
            this.pbMathOptionB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMathOptionB.BackColor = System.Drawing.Color.White;
            this.pbMathOptionB.Image = global::QuizApp.Properties.Resources.letter_b;
            this.pbMathOptionB.Location = new System.Drawing.Point(477, 142);
            this.pbMathOptionB.Name = "pbMathOptionB";
            this.pbMathOptionB.Size = new System.Drawing.Size(65, 40);
            this.pbMathOptionB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMathOptionB.TabIndex = 9;
            this.pbMathOptionB.TabStop = false;
            // 
            // pbMathOptionC
            // 
            this.pbMathOptionC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbMathOptionC.BackColor = System.Drawing.Color.White;
            this.pbMathOptionC.Image = global::QuizApp.Properties.Resources.letter_c;
            this.pbMathOptionC.Location = new System.Drawing.Point(89, 221);
            this.pbMathOptionC.Name = "pbMathOptionC";
            this.pbMathOptionC.Size = new System.Drawing.Size(65, 40);
            this.pbMathOptionC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMathOptionC.TabIndex = 7;
            this.pbMathOptionC.TabStop = false;
            // 
            // pbMathOptionA
            // 
            this.pbMathOptionA.BackColor = System.Drawing.Color.White;
            this.pbMathOptionA.Image = global::QuizApp.Properties.Resources.letter_a;
            this.pbMathOptionA.Location = new System.Drawing.Point(89, 142);
            this.pbMathOptionA.Name = "pbMathOptionA";
            this.pbMathOptionA.Size = new System.Drawing.Size(65, 40);
            this.pbMathOptionA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMathOptionA.TabIndex = 5;
            this.pbMathOptionA.TabStop = false;
            // 
            // pbMathQuestion
            // 
            this.pbMathQuestion.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pbMathQuestion.Image = global::QuizApp.Properties.Resources.question__1_;
            this.pbMathQuestion.Location = new System.Drawing.Point(177, 41);
            this.pbMathQuestion.Name = "pbMathQuestion";
            this.pbMathQuestion.Size = new System.Drawing.Size(95, 71);
            this.pbMathQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMathQuestion.TabIndex = 4;
            this.pbMathQuestion.TabStop = false;
            // 
            // tpQuizesList
            // 
            this.tpQuizesList.Controls.Add(this.label8);
            this.tpQuizesList.Controls.Add(this.groupBox1);
            this.tpQuizesList.Controls.Add(this.button3);
            this.tpQuizesList.Controls.Add(this.button2);
            this.tpQuizesList.Controls.Add(this.btnMathcQuiz);
            this.tpQuizesList.Location = new System.Drawing.Point(4, 22);
            this.tpQuizesList.Name = "tpQuizesList";
            this.tpQuizesList.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuizesList.Size = new System.Drawing.Size(855, 366);
            this.tpQuizesList.TabIndex = 0;
            this.tpQuizesList.Text = "Quizes List";
            this.tpQuizesList.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Honeydew;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label8.Location = new System.Drawing.Point(309, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 49);
            this.label8.TabIndex = 7;
            this.label8.Text = "Quizes Screen";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbTimeForEachQuestion);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(493, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 85);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time For Each Question";
            // 
            // cbTimeForEachQuestion
            // 
            this.cbTimeForEachQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeForEachQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTimeForEachQuestion.FormattingEnabled = true;
            this.cbTimeForEachQuestion.Items.AddRange(new object[] {
            "10",
            "15",
            "30",
            "45",
            "60"});
            this.cbTimeForEachQuestion.Location = new System.Drawing.Point(35, 34);
            this.cbTimeForEachQuestion.Name = "cbTimeForEachQuestion";
            this.cbTimeForEachQuestion.Size = new System.Drawing.Size(250, 33);
            this.cbTimeForEachQuestion.Sorted = true;
            this.cbTimeForEachQuestion.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DimGray;
            this.button3.Location = new System.Drawing.Point(42, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 51);
            this.button3.TabIndex = 5;
            this.button3.Text = "Soon . . .";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(42, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 51);
            this.button2.TabIndex = 4;
            this.button2.Text = "Soon . . .";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnMathcQuiz
            // 
            this.btnMathcQuiz.BackColor = System.Drawing.Color.White;
            this.btnMathcQuiz.FlatAppearance.BorderSize = 2;
            this.btnMathcQuiz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnMathcQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMathcQuiz.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMathcQuiz.ForeColor = System.Drawing.Color.DimGray;
            this.btnMathcQuiz.Location = new System.Drawing.Point(42, 34);
            this.btnMathcQuiz.Name = "btnMathcQuiz";
            this.btnMathcQuiz.Size = new System.Drawing.Size(197, 51);
            this.btnMathcQuiz.TabIndex = 3;
            this.btnMathcQuiz.Text = "Math Quiz";
            this.btnMathcQuiz.UseVisualStyleBackColor = false;
            this.btnMathcQuiz.Click += new System.EventHandler(this.btnMathcQuiz_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProfile.BackColor = System.Drawing.Color.White;
            this.btnProfile.FlatAppearance.BorderSize = 3;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnProfile.Location = new System.Drawing.Point(299, 373);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(139, 51);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Visible = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnQuizes
            // 
            this.btnQuizes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuizes.BackColor = System.Drawing.Color.White;
            this.btnQuizes.FlatAppearance.BorderSize = 0;
            this.btnQuizes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuizes.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuizes.ForeColor = System.Drawing.Color.DimGray;
            this.btnQuizes.Location = new System.Drawing.Point(466, 373);
            this.btnQuizes.Name = "btnQuizes";
            this.btnQuizes.Size = new System.Drawing.Size(139, 51);
            this.btnQuizes.TabIndex = 2;
            this.btnQuizes.Text = "Quizes";
            this.btnQuizes.UseVisualStyleBackColor = false;
            this.btnQuizes.Visible = false;
            this.btnQuizes.Click += new System.EventHandler(this.btnQuizes_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // timerMath
            // 
            this.timerMath.Interval = 1000;
            this.timerMath.Tick += new System.EventHandler(this.timerMath_Tick);
            // 
            // imageListLogin
            // 
            this.imageListLogin.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLogin.ImageStream")));
            this.imageListLogin.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLogin.Images.SetKeyName(0, "lock.png");
            this.imageListLogin.Images.SetKeyName(1, "user.png");
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.btnQuizes);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.tcScreens);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(20, 20, 20, 40);
            this.Text = "Quiz App";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tcScreens.ResumeLayout(false);
            this.tpProfile.ResumeLayout(false);
            this.tcProfile.ResumeLayout(false);
            this.tbLogin.ResumeLayout(false);
            this.tbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPasswordKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tpShowProfile.ResumeLayout(false);
            this.tpShowProfile.PerformLayout();
            this.gbQuizInformation.ResumeLayout(false);
            this.gbQuizInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpEditProfile.ResumeLayout(false);
            this.tpEditProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tpQuizes.ResumeLayout(false);
            this.tcQuizesContatiner.ResumeLayout(false);
            this.tpMathQuiz.ResumeLayout(false);
            this.tpMathQuiz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMathOptionD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMathOptionB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMathOptionC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMathOptionA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMathQuestion)).EndInit();
            this.tpQuizesList.ResumeLayout(false);
            this.tpQuizesList.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcScreens;
        private System.Windows.Forms.TabPage tpProfile;
        private System.Windows.Forms.TabPage tpQuizes;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnQuizes;
        private System.Windows.Forms.TabControl tcProfile;
        private System.Windows.Forms.TabPage tpShowProfile;
        private System.Windows.Forms.TabPage tpEditProfile;
        private System.Windows.Forms.GroupBox gbQuizInformation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblRightAnswers;
        private System.Windows.Forms.Label lblTotalQuestions;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnSaveEditProfile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tcQuizesContatiner;
        private System.Windows.Forms.TabPage tpQuizesList;
        private System.Windows.Forms.TabPage tpMathQuiz;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMathcQuiz;
        private System.Windows.Forms.Label lblMathQuestion;
        private System.Windows.Forms.Button btnMathOptionA;
        private System.Windows.Forms.PictureBox pbMathQuestion;
        private System.Windows.Forms.PictureBox pbMathOptionA;
        private System.Windows.Forms.PictureBox pbMathOptionC;
        private System.Windows.Forms.Button btnMathOptionC;
        private System.Windows.Forms.PictureBox pbMathOptionD;
        private System.Windows.Forms.Button btnMathOptionD;
        private System.Windows.Forms.PictureBox pbMathOptionB;
        private System.Windows.Forms.Button btnMathOptionB;
        private System.Windows.Forms.Label lblMathAfterAnswer;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerMath;
        private System.Windows.Forms.Label lblMathTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTimeForEachQuestion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tbLogin;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ImageList imageListLogin;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.PictureBox pbPasswordKey;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLoginWrongMessage;
        private System.Windows.Forms.Button btnBackToQuizesScreen;
    }
}

