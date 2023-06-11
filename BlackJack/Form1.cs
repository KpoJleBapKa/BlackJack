using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        private Deck deck;
        private Hand playerHand;
        private Hand dealerHand;
        private int balance = 100; // Початковий баланс гравця
        private int playerBalance = 100; 
        private int currentBet = 0; // Поточна ставка гравця
        private int betAmount = 0;
     
        public Form1()
        {
            InitializeComponent();
            InitializeGame();
            UpdateBalanceLabel();
            label1.Text = "Баланс " + playerBalance.ToString();
            button1.Text = "5 фішок";
            button2.Text = "10 фішок";
            button3.Text = "20 фішок";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartGame(5); // Почати гру зі ставкою 5
            UpdatePlayerBalance();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartGame(10); // Почати гру зі ставкою 10
            UpdatePlayerBalance();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartGame(20); // Почати гру зі ставкою 20
            UpdatePlayerBalance();
        }

        private void StartGame(int bet)
        {
            // Оновити баланс гравця
            playerBalance -= bet;
            UpdatePlayerBalance();

            currentBet = bet;

            // Почати гру
        }
        private void UpdatePlayerBalance()
        {
            // Оновити баланс гравця в лейблі
            label1.Text = "Гравець: " + playerBalance.ToString();

        }

        private void EndGame(bool isWin)
        {
            // Завершення гри
            if (isWin)
            {
                playerBalance += currentBet * 2; // Подвоєння ставки при перемозі
            }

            // Оновити баланс гравця
            UpdatePlayerBalance();

            currentBet = 0; // Скидання ставки до початкового значення
            UpdatePlayerBalance();
            // Очистити картки гравця та дилера, якщо потрібно
        }


        private void InitializeGame()
        {
            deck = new Deck();
            deck.Shuffle();

            playerHand = new Hand();
            dealerHand = new Hand();

            // Роздаємо початкові карти гравцю і дилеру
            playerHand.AddCard(deck.DealCard());
            playerHand.AddCard(deck.DealCard());

            dealerHand.AddCard(deck.DealCard());
            dealerHand.AddCard(deck.DealCard());

            UpdateUI();
            UpdatePlayerBalance();
        }

        private void UpdateUI()
        {
            UpdatePlayerHand();
            UpdateDealerHand();
            playerCardsLabel.Text = "Сума: " + playerHand.GetHandValue().ToString();
            playerCardsListBox.Items.Clear();
            foreach (Card card in playerHand.Cards)
            {
                playerCardsListBox.Items.Add(card.ToString());
            }

            dealerCardsListBox.Items.Clear();
            dealerCardsListBox.Items.Add(dealerHand.Cards[0].ToString());
            dealerCardsListBox.Items.Add("[Приховано]");
            UpdatePlayerBalance();
        }

        private void UpdatePlayerHand()
        {
            playerCardsListBox.Items.Clear();
            foreach (Card card in playerHand.Cards)
            {
                playerCardsListBox.Items.Add(card.ToString());
            }
        }

        private void UpdateDealerHand()
        {
            dealerCardsListBox.Items.Clear();
            foreach (Card card in dealerHand.Cards)
            {
                dealerCardsListBox.Items.Add(card.ToString());
            }
        }


        private void UpdateBalanceLabel()
        {
            label1.Text = "Баланс: " + balance.ToString() + " фішок";
            UpdatePlayerBalance();
        }

        private void BetButton_Click(object sender, EventArgs e)
        {
            Button betButton = (Button)sender;
            int betAmount = int.Parse(betButton.Text); // Отримати суму ставки з тексту кнопки

            if (playerBalance >= betAmount) // Перевірити, чи гравець має достатньо фішок для ставки
            {
                playerBalance -= betAmount; // Зняти ставку з балансу гравця
                currentBet += betAmount; // Додати ставку до поточної ставки гравця

                // Оновити відображення балансу та поточної ставки на лейблах
                playerBalanceLabel.Text = "Баланс: " + playerBalance.ToString();
                currentBetLabel.Text = "Поточна ставка: " + currentBet.ToString();
            }
            else
            {
                MessageBox.Show("У вас недостатньо фішок для зроблення ставки!");
            }
            UpdatePlayerBalance();
        }


        private void DealInitialCards()
        {
            playerHand.AddCard(deck.DealCard());
            playerHand.AddCard(deck.DealCard());

            dealerHand.AddCard(deck.DealCard());
            dealerHand.AddCard(deck.DealCard());

            UpdateUI();

            if (playerHand.GetHandValue() == 21)
            {
                EndGameWithBlackjack();
            }
        }

        private void EndGameWithBlackjack()
        {
            MessageBox.Show("Блекджек! Ви виграли!");
            playerBalance += currentBet * 2;
            currentBet = 0;
            UpdateBalanceLabel();
            InitializeGame();
        }


        private void HitButton_Click(object sender, EventArgs e)
        {
            playerHand.AddCard(deck.DealCard());
            UpdateUI();

            if (playerHand.GetHandValue() > 21)
            {
                MessageBox.Show("Перебор! Дилер виграв.");
                currentBet = 0;
                UpdateBalanceLabel();
                InitializeGame();
            }
        }

        private void StandButton_Click(object sender, EventArgs e)
        {
            while (dealerHand.GetHandValue() < 17)
            {
                dealerHand.AddCard(deck.DealCard());
            }

            UpdateUI();

            if (dealerHand.GetHandValue() > 21 || dealerHand.GetHandValue() < playerHand.GetHandValue())
            {
                MessageBox.Show("Ви виграли!");
                playerBalance += currentBet * 2;
            }
            else if (dealerHand.GetHandValue() > playerHand.GetHandValue())
            {
                MessageBox.Show("Дилер виграв!");
               
            }
            else
            {
                MessageBox.Show("Нічия!");
                playerBalance += currentBet;
            }

            currentBet = 0;
            UpdateBalanceLabel();
            InitializeGame();
        }



    }


    public class Deck
    {
        private List<Card> cards;
        private Random random;

        public Deck()
        {
            cards = new List<Card>();
            random = new Random();

            string[] suits = { "Черви", "Бубни", "Крести", "Піки" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Валет", "Дама", "Король", "Туз" };

            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    cards.Add(new Card(suit, rank));
                }
            }
        }

        public void Shuffle()
        {
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }

        public Card DealCard()
        {
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }
    }

    public class Hand
    {
        private List<Card> cards;

        public Hand()
        {
            cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public int GetHandValue()
        {
            int value = 0;
            int numAces = 0;

            foreach (Card card in cards)
            {
                if (card.Rank == "Туз")
                {
                    value += 11;
                    numAces++;
                }
                else if (card.Rank == "Валет" || card.Rank == "Дама" || card.Rank == "Король")
                {
                    value += 10;
                }
                else
                {
                    value += int.Parse(card.Rank);
                }
            }

            while (value > 21 && numAces > 0)
            {
                value -= 10;
                numAces--;
            }

            return value;
        }

        public List<Card> Cards
        {
            get { return cards; }
        }
    }

    public class Card
    {
        public string Suit { get; }
        public string Rank { get; }

        public Card(string suit, string rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public override string ToString()
        {
            return Rank + " " + Suit;
        }
    }


}
