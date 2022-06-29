namespace MoneyBook
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            DialogResult result = f.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //로그인이 성공됨.
                //1. 자료를 불러와서 표시(목록)
                //2. 입/출금 등록 버튼을 활성화 
                btIN.Enabled = true; 
                btOut.Enabled = true; 
            }
            else
            {
                //로그인이 실패함.
                //1. 현재 표시되는 목록 제거 
                //2. 입/출금 등록 버튼을 비활성 
                btIN.Enabled = false; // 입금버튼 비활성
                btOut.Enabled = false; //// 입금버튼 비활성
            }
        }

        private void btIN_Click(object sender, EventArgs e)
        {
            fIN f = new fIN();
            DialogResult result = f.ShowDialog();
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                //데이터를 추가한다. 
                
                DateTime 입력일 = f.dtDate.Value;
                string 분류 = f.tbType.Text;
                string 금액 = f.tbAmt.Text;
                string 비고 = f.tbMemo.Text;

                //데이터 추가
                //(미구현)

                //목록에 추가 
                ListViewItem lv =lv1.Items.Add(입력일.ToShortDateString());
                lv.SubItems.Add(분류);
                lv.SubItems.Add(금액);
                lv.SubItems.Add("");// 출금
                lv.SubItems.Add(비고);


            }
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            fOut f = new fOut();
            DialogResult result = f.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //데이터를 추가한다. 

                DateTime 입력일 = f.dtDate.Value;
                string 분류 = f.tbType.Text;
                string 금액 = f.tbAmt.Text;
                string 비고 = f.tbMemo.Text;

                //데이터 추가
                //(미구현)

                //목록에 추가 
                ListViewItem lv = lv1.Items.Add(입력일.ToShortDateString());
                lv.SubItems.Add(분류);
                lv.SubItems.Add("");//입금
                lv.SubItems.Add(금액);
                lv.SubItems.Add(비고);


            }
        }

        private void BtEdit_Click(object sender, EventArgs e)
        {
            //편집메뉴
            if(lv1.SelectedItems.Count <1)
            {
                MessageBox.Show("테이블을 선택하세요");
                return;
            }

            //선택된 자료의 구분을 확인한다.
            ListViewItem lv =lv1.SelectedItems[0];
            string 날짜 = lv.SubItems[0].Text;
            string 분류 = lv.SubItems[1].Text;
            string 입금액 = lv.SubItems[2].Text;
            string 출금액 = lv.SubItems[3].Text;
            string 비고 = lv.SubItems[4].Text;


            if (입금액 !="")
            {
                //입금화면을 호출하고 현재 데이터를 전송
                fIN f = new fIN(날짜, 분류, 입금액,비고);
                if(f.ShowDialog()== System.Windows.Forms.DialogResult.OK)
                {
                    //현재 선택된 자료를 업데이트 합니다.
                    lv.SubItems[0].Text = f.dtDate.Value.ToShortDateString(); //2022-12-31
                    lv.SubItems[1].Text = f.tbType.Text;
                    lv.SubItems[2].Text = f.tbAmt.Text;
                    lv.SubItems[3].Text = "";
                    lv.SubItems[4].Text = f.tbMemo.Text;
                }
            }
            else
            {
                //출금화면을 호출하고...
                fOut f = new fOut(날짜, 분류, 입금액, 비고);
                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //현재 선택된 자료를 업데이트 합니다.
                    lv.SubItems[0].Text = f.dtDate.Value.ToShortDateString(); //2022-12-31
                    lv.SubItems[1].Text = f.tbType.Text;
                    lv.SubItems[2].Text = f.tbAmt.Text;
                    lv.SubItems[3].Text = "";
                    lv.SubItems[4].Text = f.tbMemo.Text;

                }

            }

        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            //삭제메뉴
            if (lv1.SelectedItems.Count < 1)
            {
                MessageBox.Show("테이블을 선택하세요");
                return;
            }

            DialogResult result = MessageBox.Show("삭제하시겠습니다까?", "삭제확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == System.Windows.Forms.DialogResult.Yes)
            {
                ListViewItem lv = lv1.SelectedItems[0];
                lv1.Items.Remove(lv);
                MessageBox.Show("삭제완료"); 
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            //저장하기
            //날짜, 분류, 입금, 출금, 비고
            string 파일명 = AppDomain.CurrentDomain.BaseDirectory + "Data\\2018-12.csv";
            string 내용 = "";

            System.IO.File.WriteAllText(파일명, 내용);
            Console.WriteLine("저장파일명=" + 파일명);
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            //불러오기
            //
        }
    }
}