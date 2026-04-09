namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblMessage.Visible = false; // 시작할 때 에러 메시지 라벨은 숨긴다
            lblTotalCost.Text = "총 금액: 0원";// 시작할 때 총 금액을 0원으로 표시한다
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 프로그램 시작 시 라디오 버튼이 포커스를 받으면 자동으로 체크되는 현상을 막기 위해
            // 포커스를 다음 탭 순서인 감자튀김(chkPotato)으로 옮깁니다.
            this.ActiveControl = chkPotato;

            rdoHamBurger.Checked = false; // 햄버거 선택 상태 해제
            rdoHamBurger.TabStop = true;  // 탭 이동이 가능하도록 설정 유지
        }

        private void UpdateOrder(bool showMessage) // 주문 내역과 총 금액을 갱신하는 메서드를 만든다
        {
            int totalCost = 0; // 총 금액을 저장할 변수를 0으로 시작한다

            lstOrder.Items.Clear(); // 이전 주문 내역을 지운다
            lblMessage.Visible = false; // 이전 에러 메시지를 숨긴다
            lblMessage.Text = ""; // 이전 에러 문구를 지운다

            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked) // 아무 메뉴도 선택하지 않았는지 확인한다
            {
                lblTotalCost.Text = "총 금액: 0원"; // 메뉴가 없으면 총 금액을 0원으로 표시한다

                if (showMessage) // 에러 메시지를 보여줘야 하는 상황인지 확인한다
                {
                    lblMessage.Text = "메뉴를 선택하세요."; // 에러 메시지 문구를 설정한다
                    lblMessage.Visible = true; // 에러 메시지 라벨을 보이게 한다
                }

                return; // 더 아래 계산은 하지 않고 메서드를 종료한다
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

            lblTotalCost.Text = "총 금액: " + totalCost.ToString("N0") + "원"; // 계산된 총 금액을 쉼표 형식으로 라벨에 표시한다
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            UpdateOrder(true);
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

        private void MenuOption_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrder(false); // 선택이 바뀌는 즉시 주문 내역과 총 금액을 갱신
        }
    }
}
