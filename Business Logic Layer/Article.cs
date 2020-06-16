using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_layer;
namespace Business_Logic_Layer
{
    public class Article
    {
        Articles_Method article = null;
        public Article()
        {
            article = new Articles_Method();
        }
        public List<Articles> GetAllArticleNonAccept()
        {
            return article.getallarticlenonaccept();
        }
        public bool AcceptArticle(Articles articles)
        {
            return article.acceptarticle(articles);
        }
        public bool NewArticle(Articles Ac)
        {
            return article.newarticle(Ac);
        }
        public List<Articles> GetTopThreeArticle()
        {
            return article.gettopthreearticle();
        }
        public List<Articles> GetAllArticleAccept()
        {
            return article.getallarticleaccept();
        }
        public List<Articles> GetArticleDetails(int id)
        {
            return article.getarticledetails(id);
        }
    }

}
