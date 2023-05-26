using IdGen;
using Microsoft.EntityFrameworkCore;
using WalkOfFameServer.Database.Seeds;
using WalkOfFameServer.Models;

namespace WalkOfFameServer.Database.Seeders
{
    public class ArticleSeeder : BaseSeeder
    {
        public ArticleSeeder(ModelBuilder modelBuilder, IdGenerator idGenerator) : base(modelBuilder, idGenerator)
        {
        }

        public override void Seed()
        {
            var article1 = new Article
            {
                Id = IdGenerator.CreateId(),
                ImageUrl = "https://img.ifunny.co/images/a6461562485385dc15fa6326fff4044c7cc0b51ef93358ce7ca0d68e1c4c2e2e_1.jpg",
                CreatedAt = DateTime.Now,
                EditedAt = DateTime.Now
            };

            var articleContent1 = new ArticleContent
            {
                ArticleId = article1.Id,
                Language = "pt-BR",
                Title = "Raluca realmente esta correto ?",
                Body = "Recentemente, uma situação perturbadora veio à tona. Raluca, de forma imprópria, vazou detalhes de uma conversa privada e íntima que teve com Jean L. Esse ato não apenas violou a confiança entre Raluca e Jean, mas também levantou questões sérias sobre o respeito à privacidade na era digital. Compartilhar informações privadas sem consentimento é um ato que vai contra os princípios básicos de respeito e confiança. É importante que todos reconheçam a gravidade de tais ações e se esforcem para preservar e respeitar a privacidade dos outros."
            };

            var article2 = new Article
            {
                Id = IdGenerator.CreateId(),
                ImageUrl = "https://imagens.brasil.elpais.com/resizer/dNsZX2voZ8BNKXO_tJ8EbjvKKnc=/1960x1103/filters:focal(2584x636:2594x646)/cloudfront-eu-central-1.images.arcpublishing.com/prisa/JQJ6QLOMPJELBEBUETGB2KTWNU.jpg",
                CreatedAt = DateTime.Now,
                EditedAt = DateTime.Now
            };

            var articleContent2 = new ArticleContent
            {
                ArticleId = article2.Id,
                Language = "pt-BR",
                Title = "Corajoso, Michael Douglas revela seus vicios.",
                Body = "Um dos primeiros a tornar pública sua compulsão por sexo, nos anos 1990, o ator Michael Douglas chegou a passar por tratamentos em uma clínica especializada após as filmagens de \"Instinto selvagem\" (1992)."
            };

            ModelBuilder.Entity<Article>().HasData(article1, article2);
            ModelBuilder.Entity<ArticleContent>().HasData(articleContent1, articleContent2);
        }
    }
}
