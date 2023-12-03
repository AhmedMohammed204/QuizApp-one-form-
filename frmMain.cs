using QuizApp.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class frmMain : Form
    {
        enum enTaps
        {
            enProfile = 0,
            enQuizes
        }
        enum enProfileTaps
        {
            enLogin = 0,
            enShowProfile,
            enEditProfile
        }
        struct stUserData
        {
            public string FirstName;
            public string LastName;
            public string Username;
            public int TotalQuestions;
            public int RightAnswers;
        }
        stUserData UserData = new stUserData();

        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            txtLoginUsername.Focus();
            cbTimeForEachQuestion.SelectedIndex = 0;
        }
        //Login
        private void txtLogin_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.ForeColor = Color.LightSeaGreen;
        }
        private void txtLogin_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.ForeColor = Color.DimGray;
        }
        private void pbPasswordKey_Click(object sender, EventArgs e)
        {
            if (txtLoginPassword.PasswordChar == '\0')
            {
                pbPasswordKey.Image = Resources.hide;
                txtLoginPassword.PasswordChar = '*';
            }
            else
            {
                pbPasswordKey.Image = Resources.visible;
                txtLoginPassword.PasswordChar = '\0';
            }

        }
        bool CheckLoginData()
        {
            if (txtLoginPassword.Text == txtLoginPassword.Tag.ToString()
                && txtLoginUsername.Text == txtLoginUsername.Tag.ToString())
                return true;
            else
                return false;
        }
        void ErrorLoginMessage()
        {
            lblLoginWrongMessage.Visible = true;
            txtLoginUsername.Focus();
        }
        void FillProfileLables()
        {
            lblFirstName.Text = UserData.FirstName;
            lblLastName.Text = UserData.LastName;
            lblUsername.Text = UserData.Username;
            lblTotalQuestions.Text = UserData.TotalQuestions.ToString();
            lblRightAnswers.Text = UserData.RightAnswers.ToString();
        }
        void SetUpUserProfileData()
        {
            UserData.FirstName = "Ahmed";
            UserData.LastName = "Mohammed";
            UserData.Username = "@" + "Ahmeded";
            UserData.TotalQuestions = 0;
            UserData.RightAnswers = 0;
            FillProfileLables();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!CheckLoginData())
            {
                ErrorLoginMessage();
                return;
            }


            SetUpUserProfileData();
            lblLoginWrongMessage.Visible = false;
            tcProfile.SelectedIndex = 1;
            this.AcceptButton = btnQuizes;
            btnProfile.Visible = true;
            btnQuizes.Visible = true;
        }

        // Main Buttons
        private void btnProfile_Click(object sender, EventArgs e)
        {
            FillProfileLables();

            tcScreens.SelectedIndex = (byte)enTaps.enProfile;
            btnQuizes.FlatAppearance.BorderSize = 0;
            btnQuizes.ForeColor = Color.DimGray;
            btnProfile.FlatAppearance.BorderSize = 3;
            btnProfile.ForeColor = Color.LightSeaGreen;
            this.AcceptButton = btnQuizes;

        }
        private void btnQuizes_Click(object sender, EventArgs e)
        {
            //Update btn
            tcScreens.SelectedIndex = (byte)enTaps.enQuizes;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.ForeColor = Color.DimGray;
            btnQuizes.FlatAppearance.BorderSize = 3;
            btnQuizes.ForeColor = Color.LightSeaGreen;

            cbTimeForEachQuestion.Focus();


            this.AcceptButton = btnProfile;

        }


        //Edit Profile
        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox s = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(s.Text))
            {
                e.Cancel = true;
                s.Focus();
                errorProvider1.SetError(s, "Please put a value");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(s, "");
            }
        }
        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            tcProfile.SelectedIndex = (byte)enProfileTaps.enEditProfile;
            this.AcceptButton = btnSaveEditProfile;
            txtFirstName.Text = lblFirstName.Text;
            txtFirstName.Focus();
            txtLastName.Text = lblLastName.Text;
            txtUsername.Text = lblUsername.Text;
            btnQuizes.Enabled = false;
            btnProfile.Enabled = false;

        }
        private void btnSaveEditProfile_Click(object sender, EventArgs e)
        {
            // Don't Forget to check Username in database
            if (MessageBox.Show("Are sure you want to update your data?", "Sure?", MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            this.AcceptButton = btnQuizes;
            btnQuizes.Focus();
            UserData.FirstName = txtFirstName.Text;
            UserData.LastName = txtLastName.Text;
            UserData.Username = txtUsername.Text;
            tcProfile.SelectedIndex = (byte)enProfileTaps.enShowProfile;
            btnQuizes.Enabled = true;
            btnProfile.Enabled = true;
            FillProfileLables();

        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            //Check In Database
        }



        // Math Quiz Screen

        struct stMathQuizData
        {
            public byte Time;
            public string Question;
            public char Operation;
            public int Num1;
            public int Num2;
            public int OptionA;
            public int OptionB;
            public int OptionC;
            public int OptionD;
            public int RightAnswer;
        }
        stMathQuizData MathQuizData = new stMathQuizData();
        
        Random rd = new Random();
        int GetRandomNumber(int From, int To)
        {
            return rd.Next(From, To);
        }
        void GetMathOperation()
        {
            char[] OpArr = { '+', '-', '*', '/' };
            MathQuizData.Operation = OpArr[GetRandomNumber(0, 3)];
        }
        void FillMathNum1AndNum2()
        {
            MathQuizData.Num1 = GetRandomNumber(1, 100);
            MathQuizData.Num2 = GetRandomNumber(1, 100);
            GetMathOperation();
            MathQuizData.Question = $"{MathQuizData.Num1} {MathQuizData.Operation} {MathQuizData.Num2}";
        }
        void GetMathRightAnswer()
        {
            FillMathNum1AndNum2();
            switch (MathQuizData.Operation)
            {
                case '+':
                    MathQuizData.RightAnswer = MathQuizData.Num1 + MathQuizData.Num2;
                    break;
                case '-':
                    MathQuizData.RightAnswer = MathQuizData.Num1 - MathQuizData.Num2;
                    break;
                case '*':
                    MathQuizData.RightAnswer = MathQuizData.Num1 * MathQuizData.Num2;
                    break;
                default:
                    MathQuizData.RightAnswer = MathQuizData.Num1 / MathQuizData.Num2;
                    break;
            }
        }
        int FillMathOptions()
        {
            int Option = default;
            do
            {
                Option = GetRandomNumber(1, 100);
            } while (Option == MathQuizData.RightAnswer);

            return Option;
        }
        enum enOptions
        {
            enA = 0, enB = 1, enC = 2, enD = 3
        }
        enOptions MathOptions;
        void PutRightAnswerInRandomOption()
        {
            MathOptions = (enOptions)GetRandomNumber(0, 3);
            switch(MathOptions)
            {
                case enOptions.enA:
                    MathQuizData.OptionA = MathQuizData.RightAnswer;
                    break;
                case enOptions.enB:
                    MathQuizData.OptionB = MathQuizData.RightAnswer;
                    break;
                case enOptions.enC:
                    MathQuizData.OptionC = MathQuizData.RightAnswer;
                    break;
                default:
                    MathQuizData.OptionD = MathQuizData.RightAnswer;
                    break;
            }
        }
        void StartMathQuiz()
        {
            UserData.TotalQuestions++;
            GetMathRightAnswer();
            MathQuizData.Time = (byte)Convert.ToInt16(cbTimeForEachQuestion.Text);
            MathQuizData.OptionA = FillMathOptions();
            MathQuizData.OptionB = FillMathOptions();
            MathQuizData.OptionC = FillMathOptions();
            MathQuizData.OptionD = FillMathOptions();
            PutRightAnswerInRandomOption();
        }
        void FillMathScreenLabels()
        {
            lblMathQuestion.Text = MathQuizData.Question;
            btnMathOptionA.Text = MathQuizData.OptionA.ToString();
            btnMathOptionB.Text = MathQuizData.OptionB.ToString();
            btnMathOptionC.Text = MathQuizData.OptionC.ToString();
            btnMathOptionD.Text = MathQuizData.OptionD.ToString();
        }
        void SetUpUI()
        {
            FillMathScreenLabels();
            StartMathTimer();
        }
        TimeSpan ts;
        void StartMathTimer()
        {
            ts = new TimeSpan(0, 0, MathQuizData.Time);
            timerMath.Enabled = true;
        }
        private void btnMathcQuiz_Click(object sender, EventArgs e)
        {
            tcQuizesContatiner.SelectedIndex = 1;
            MathQuizData.Time = 10;
            
            StartMathQuiz();
            SetUpUI();
        }

        // Quetion Options Buttons
        void ToggleButtonsEnableDisable(bool Enable)
        {
            btnMathOptionA.Enabled = Enable;
            btnMathOptionB.Enabled = Enable;
            btnMathOptionC.Enabled = Enable;
            btnMathOptionD.Enabled = Enable;
        }
        void ChangeMathOptionImageBackColor(Color Color, Button btn)
        {
            switch(btn.Name)
            {
                case "btnMathOptionA":
                    pbMathOptionA.BackColor = Color;
                    break;
                case "btnMathOptionB":
                    pbMathOptionB.BackColor = Color;
                    break;
                case "btnMathOptionC":
                    pbMathOptionC.BackColor = Color;
                    break;
                default:
                    pbMathOptionD.BackColor = Color;
                    break;
            }

        }
        bool CheckAnswer(Button btn)
        {
            ToggleButtonsEnableDisable(false);
            if (btn.Text != MathQuizData.RightAnswer.ToString())
            {
                ChangeMathOptionImageBackColor(Color.Tomato, btn);
                btn.BackColor = Color.Tomato;
                return false;
            }
            else
            {
                ChangeMathOptionImageBackColor(Color.LightGreen, btn);
                btn.BackColor = Color.LightGreen;
                return true;
            }
        }
        private void btnMathOption_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.FlatAppearance.BorderColor = Color.LightSeaGreen;
            btn.ForeColor = Color.LightSeaGreen;
        }
        private void btnMathOption_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.FlatAppearance.BorderColor = Color.DimGray;
            btn.ForeColor = Color.DimGray;
        }
        void PauseTimer()
        {
            timerMath.Enabled = false;
            lblMathTimer.ForeColor = Color.LightSeaGreen;

        }
        private void btnMathOption_Click(object sender, EventArgs e)
        {
            PauseTimer();
            lblMathAfterAnswer.Visible = true;
            if(CheckAnswer((Button)sender))
            {
                UserData.RightAnswers++;
                lblMathAfterAnswer.BackColor = Color.LightGreen;
                lblMathAfterAnswer.Text = "Great!" + Environment.NewLine;
                lblMathAfterAnswer.Text += "Your answer is true. You can go to the next question.";
                btnNextQuestion.Text = "Next Question ->";
            }
            else
            {
                lblMathAfterAnswer.BackColor = Color.Tomato;
                lblMathAfterAnswer.Text = "Oops!" + Environment.NewLine;
                lblMathAfterAnswer.Text += $"The right answer is {MathQuizData.RightAnswer}. Try again with new question )':";
                btnNextQuestion.Text = "Try Again";
            }
            btnNextQuestion.Visible = true;
        }
        void ResetMathGame()
        {
            lblMathAfterAnswer.Visible = false;
            btnNextQuestion.Visible = false;
            ToggleButtonsEnableDisable(true);
            btnMathOptionA.BackColor = Color.White;
            btnMathOptionB.BackColor = Color.White;
            btnMathOptionC.BackColor = Color.White;
            btnMathOptionD.BackColor = Color.White;

            pbMathOptionA.BackColor = Color.White;
            pbMathOptionB.BackColor = Color.White;
            pbMathOptionC.BackColor = Color.White;
            pbMathOptionD.BackColor = Color.White;

        }
        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            ResetMathGame();
            StartMathQuiz();
            SetUpUI();
        }
        private void timerMath_Tick(object sender, EventArgs e)
        {
            ts = new TimeSpan(ts.Hours, ts.Minutes, ts.Seconds - 1);
            lblMathTimer.Text = ts.Seconds.ToString();

            if(ts == new TimeSpan(0,0,0))
            {
                PauseTimer();
                ToggleButtonsEnableDisable(false);
                lblMathAfterAnswer.BackColor = Color.DimGray;
                lblMathAfterAnswer.Text = "Time is up!" + Environment.NewLine;
                lblMathAfterAnswer.Visible = true;
                btnNextQuestion.Text = "Next";
                btnNextQuestion.Visible = true;

                

            }
        }

        private void btnBackToQuizesScreen_Click(object sender, EventArgs e)
        {
            timerMath.Enabled = false;
            tcQuizesContatiner.SelectedIndex = 0;
        }
    }
}
