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
            string 입금액 = lv.SubItems[1].Text;
            string 출금액 = lv.SubItems[2].Text;
            if(입금액 !="")
            {
                //입금화면을 호출하고 현재 데이터를 전송
                fIN f = new fIN();
                f.ShowDialog();
            }
            else
            {
                //출금화면을 호출하고...
                fOut f = new fOut();
                f.ShowDialog();

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
        }
    }
}