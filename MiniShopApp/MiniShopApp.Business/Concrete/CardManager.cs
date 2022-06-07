using MiniShopApp.Business.Abstract;
using MiniShopApp.Data.Abstract;
using MiniShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Business.Concrete
{
    public class CardManager : ICardService
    {
        private ICardRepository _cardRepository;
        public CardManager(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public void DeleteFromCard(string userId, int productId)
        {
            var card = GetCardByUserId(userId);
            if (card!=null)
            {
                _cardRepository.DeleteFromCard(card.Id,productId);
            }
        }
        public void AddToCard(string userId, int productId, int quantity)
        {
            var card = GetCardByUserId(userId);
            if (card!=null)
            {
                var index = card.CardItems.FindIndex(i => i.ProductId == productId);
                if (index<0)//eğer ürün daha card'da yoksa
                {
                    card.CardItems.Add(new CardItem()
                    {
                        ProductId=productId,
                        Quantity=quantity,
                        CardId=card.Id
                    });
                }
                else
                {
                    card.CardItems[index].Quantity += quantity;
                }
                _cardRepository.Update(card);
            }
        }

        public Card GetCardByUserId(string userId)
        {
            return _cardRepository.GetByUserId(userId);
        }

        public void InitializeCard(string userId)
        {
            _cardRepository.Create(new Card() { UserId=userId});
        }
    }
}
