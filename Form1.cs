namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnOrder_Click(object sender, EventArgs e)
        {
            int totalCost = 0; // 총 금액을 저장할 변수를 0으로 시작한다

            lstOrder.Items.Clear(); // 이전 주문 내역이 남아있지 않도록 리스트를 비운다

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

            lblTotalCost.Text = "총 금액: " + totalCost + "원"; // 계산된 총 금액을 라벨에 표시한다
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false; // 햄버거 선택을 해제한다
            rdoBulgogiBurger.Checked = false; // 불고기버거 선택을 해제한다
            rdoChickenBurger.Checked = false; // 치킨버거 선택을 해제한다
            chkPotato.Checked = false; // 감자튀김 선택을 해제한다
            chkCola.Checked = false; // 콜라 선택을 해제한다
            chkCheese.Checked = false; // 치즈 추가 선택을 해제한다
            chkSauce.Checked = false; // 소스 추가 선택을 해제한다
            lstOrder.Items.Clear(); // 주문 내역 리스트를 비운다
            lblTotalCost.Text = "총 금액: 0원"; // 총 금액 라벨을 초기값으로 되돌린다
        }
    }
}
