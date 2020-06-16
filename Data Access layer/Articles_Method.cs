using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Data_Access_layer
{
  public  class Articles_Method
    {
      public bool acceptarticle(Articles articles)
      {
          SqlParameter[] parameters = new SqlParameter[]
		{
            	new SqlParameter("@ArticleId",articles.ArticleId)
		};
          return DBHelper.ExecuteNonQuery("sp_AcceptArticle", CommandType.StoredProcedure, parameters);
      }
      public List<Articles> getallarticlenonaccept()
      {
          List<Articles> ListArticle = null;
          using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetAllArticleNonAccept", CommandType.StoredProcedure))
          {
              if (table.Rows.Count > 0)
              {
                  ListArticle = new List<Articles>();
                  foreach (DataRow row in table.Rows)
                  {
                      Articles Ac = new Articles();
                      Ac.UserName = row["UserName"].ToString();
                      Ac.ArticleId = Convert.ToInt32(row["Article_Id"]);
                      Ac.ArticleTitle = row["Article_Title"].ToString();
                      Ac.ArticleAccept = Convert.ToBoolean(row["Article_Accept"]);
                      ListArticle.Add(Ac);
                  }
              }
          }
          return ListArticle;
      }
      public bool newarticle(Articles Ac)
      {
          SqlParameter[] Parameters = new SqlParameter[]
          {
              new SqlParameter("@Title",Ac.ArticleTitle),
              new SqlParameter("@Details",Ac.ArticleDetails),
              new SqlParameter("@Photo",Ac.ArticlePhoto),
              new SqlParameter("UserId",Ac.UserId)
          };
          return DBHelper.ExecuteNonQuery("sp_NewArticle", CommandType.StoredProcedure, Parameters);
      }
      public List<Articles> gettopthreearticle()
      {
          List<Articles> ListArticle = null;
          using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetTopThreeArticles", CommandType.StoredProcedure))
          {
              if (table.Rows.Count > 0)
              {
                  ListArticle = new List<Articles>();
                  foreach (DataRow row in table.Rows)
                  {
                      Articles Ac = new Articles();
                      Ac.ArticleId = Convert.ToInt32(row["Article_Id"]);
                      Ac.ArticleTitle = row["Title"].ToString();
                      Ac.ArticleDatePublish = Convert.ToDateTime(row["Article_Date"]);
                      Ac.ArticlePhoto=row["Article_Photo"].ToString();
                      Ac.ArticleDetails = row["Details"].ToString();
                      ListArticle.Add(Ac);
                  }
              }
          }
          return ListArticle;
      }
      public List<Articles> getallarticleaccept()
      {
          List<Articles> ListArticle = null;
          using (DataTable table = DBHelper.ExecuteSelectCommand("sp_GetAllArticleAccept", CommandType.StoredProcedure))
          {
              if (table.Rows.Count > 0)
              {
                  ListArticle = new List<Articles>();
                  foreach (DataRow row in table.Rows)
                  {
                      Articles Ac = new Articles();
                      Ac.ArticleId = Convert.ToInt32(row["Article_Id"]);
                      Ac.ArticleTitle = row["Article_Title"].ToString();
                      Ac.ArticleDatePublish = Convert.ToDateTime(row["Article_Date"]);
                      Ac.ArticlePhoto = row["Article_Photo"].ToString();
                      Ac.ArticleDetails = row["Article_Details"].ToString();
                      Ac.UserName = row["UserName"].ToString();
                      ListArticle.Add(Ac);
                  }
              }
          }
          return ListArticle;
      }
      public List<Articles> getarticledetails(int id)
      {
          List<Articles> ListArticle = null;
          SqlParameter[] Parameters = new SqlParameter[]
          {
              new SqlParameter("@Id",id)
          };
          using (DataTable table = DBHelper.ExecuteParamerizedSelectCommand("sp_GetArticleDetails", CommandType.StoredProcedure, Parameters))
          {
              if (table.Rows.Count > 0)
              {
                  ListArticle = new List<Articles>();
                  foreach (DataRow row in table.Rows)
                  {
                      Articles Ac = new Articles();
                      Ac.ArticleId = Convert.ToInt32(row["Article_Id"]);
                      Ac.ArticleTitle = row["Article_Title"].ToString();
                      Ac.ArticleDatePublish = Convert.ToDateTime(row["Article_Date"]);
                      Ac.ArticlePhoto = row["Article_Photo"].ToString();
                      Ac.ArticleDetails = row["Article_Details"].ToString();
                      Ac.UserName = row["UserName"].ToString();
                      ListArticle.Add(Ac);
                  }
              }
          }
          return ListArticle;
      }
    }
}
