namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblMessage.Visible = false; // 시작할 때 에러 메시지 라벨은 숨긴다
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 폼 시작 시 첫 포커스를 받으며 자동으로 라디오 버튼이 체크되는 현상을 방지하기 위해 
            // 로딩 처리가 끝난 직후 비동기(BeginInvoke)로 체크를 해제합니다.
            this.BeginInvoke(new Action(() => 
            {
                rdoHamBurger.Checked = false; // 햄버거 선택을 해제한다 (이때 TabStop도 false로 변경됨)
                rdoHamBurger.TabStop = true; // 다시 TabStop을 true로 설정하여 탭 키로 포커스 가능하게 만듦
            }));
        }


        private void btnOrder_Click(object sender, EventArgs e)
        {
            int totalCost = 0; // 총 금액을 저장할 변수를 0으로 시작한다

            lblMessage.Visible = false; // 이전 에러 메시지를 숨긴다
            lblMessage.Text = ""; // 이전 에러 문구를 지운다
            lstOrder.Items.Clear(); // 이전 주문 내역이 남아있지 않도록 리스트를 비운다

            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked) // 아무 메뉴도 선택하지 않았는지 확인한다
            {
                lblMessage.Text = "메뉴를 선택하세요."; // 라벨에 에러 메시지를 표시한다
                lblMessage.Visible = true; // 에러 메시지 라벨을 보이게 한다
                lblTotalCost.Text = "총 금액: 0원";
                return; //주문 계산은 하지 않고 종료한다
            }

            if (rdoHamBurger.Checked) // 햄버거가 선택되었는지 확인한다
            {
                totalCost += 5000; // 햄버거 가격 5000원을 총 금액에 더한다
                lstOrder.Items.Add("햄버거 5,000원"); // 주문 내역 리스트에 햄버거를 추가한다
            }
            else if (rdoBulgogiBurger.Checked) // 불고기버거가 선택되었는지 확인한다
            {
                totalCost += 4000; // 불고기버거 가격 4000원을 총 금액에 더한다
                lstOrder.Items.Add("불고기버거 4,000원"); // 주문 내역 리스트에 불고기버거를 추가한다
            }
            else if (rdoChickenBurger.Checked) // 치킨버거가 선택되었는지 확인한다
            {
                totalCost += 3000; // 치킨버거 가격 3000원을 총 금액에 더한다
                lstOrder.Items.Add("치킨버거 3,000원"); // 주문 내역 리스트에 치킨버거를 추가한다
            }

            if (chkPotato.Checked) // 감자튀김이 선택되었는지 확인한다
            {
                totalCost += 3500; // 감자튀김 가격 3500원을 총 금액에 더한다
                lstOrder.Items.Add("감자튀김 3,500원"); // 주문 내역 리스트에 감자튀김을 추가한다
            }

            if (chkCola.Checked) // 콜라가 선택되었는지 확인한다
            {
                totalCost += 2500; // 콜라 가격 2500원을 총 금액에 더한다
                lstOrder.Items.Add("콜라 2,500원"); // 주문 내역 리스트에 콜라를 추가한다
            }

            if (chkCheese.Checked) // 치즈 추가가 선택되었는지 확인한다
            {
                totalCost += 1500; // 치즈 추가 가격 1500원을 총 금액에 더한다
                lstOrder.Items.Add("치즈 추가 1,500원"); // 주문 내역 리스트에 치즈 추가를 추가한다
            }

            if (chkSauce.Checked) // 소스 추가가 선택되었는지 확인한다
            {
                totalCost += 500; // 소스 추가 가격 500원을 총 금액에 더한다
                lstOrder.Items.Add("소스 추가 500원"); // 주문 내역 리스트에 소스 추가를 추가한다
            }

            lblTotalCost.Text = "총 금액: " + totalCost.ToString("N0") + "원"; // 계산된 총 금액을 라벨에 표시한다
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false; // 햄버거 선택을 해제한다
            rdoBulgogiBurger.Checked = false; // 불고기버거 선택을 해제한다
            rdoChickenBurger.Checked = false; // 치킨버거 선택을 해제한다

            rdoHamBurger.TabStop = true; // 선택 해제 시 TabStop이 false가 되므로 탭 진입이 가능하게 다시 true로 설정

            chkPotato.Checked = false; // 감자튀김 선택을 해제한다
            chkCola.Checked = false; // 콜라 선택을 해제한다
            chkCheese.Checked = false; // 치즈 추가 선택을 해제한다
            chkSauce.Checked = false; // 소스 추가 선택을 해제한다
            lstOrder.Items.Clear(); // 주문 내역 리스트를 비운다
            lblTotalCost.Text = "총 금액: 0원"; // 총 금액 라벨을 초기값으로 되돌린다

            lblMessage.Visible = false; // 에러 메시지 라벨을 다시 숨긴다
        }


    }
}
