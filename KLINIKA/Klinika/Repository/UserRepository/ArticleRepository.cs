using Model.UserModel;
using System;
using Klinika.Repository;
using System.Linq;
using System.Collections.Generic;

namespace Repository.UserRepository
{
    public class ArticleRepository : IArticleRepository
    {
        private static ArticleRepository instance { get; set; }
        private FileRepository<Article> stream { get; set; }

        public static ArticleRepository GetInstance(FileRepository<Article> stream)
        {
            if(instance == null)
            {
                instance = new ArticleRepository(stream);
            }
            return instance;
        }

        private ArticleRepository(FileRepository<Article> stream)
        {
            this.stream = stream;
        }

        public List<Article> GetAllArticles()
        {
            return stream.GetAll().ToList();
        }

        public Article GetArticleById(String title)
        {
            foreach (Article article in stream.GetAll().ToList())
            {
                if (article.title.Equals(title))
                {
                    return article;
                }
            }
            return null;
        }

        public object Add(object obj)
        {
            var allArticles = stream.GetAll().ToList();
            allArticles.Add((Article)obj);
            stream.SaveAll(allArticles);
            return obj;
        }

        public object Edit(object obj)
        {
            var allArticles = stream.GetAll().ToList();
            var editedArticle = (Article)obj;
            foreach(Article article in allArticles)
            {
                if(article.title.Equals(editedArticle.title))
                {
                    EditAllAttributes(article, editedArticle);
                }
            }
            stream.SaveAll(allArticles);
            return obj;
        }

        public bool Delete(object obj)
        {
            var allArticles = stream.GetAll().ToList();
            if (allArticles.Remove((Article)obj))
            {
                stream.SaveAll(allArticles);
                return true;
            }
            return false;
        }

        private void EditAllAttributes(Article article,Article editedArticle)
        {
            article.doctor = editedArticle.doctor;
            article.title = editedArticle.title;
            article.text = editedArticle.text;
            article.date = editedArticle.date;
        }

    }
}