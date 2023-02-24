using System;
using Repository.UserRepository;
using Model.UserModel;
using System.Collections.Generic;

namespace Service.UserService
{
    public class ArticleService : IArticleService
    {
        private static ArticleService instance { get; set; }
        private ArticleRepository articleRepository { get; set; }

        public static ArticleService GetInstance(ArticleRepository articleRepository)
        {
            if(instance == null)
            {
                instance = new ArticleService(articleRepository);
            }
            return instance;
        }

        private ArticleService(ArticleRepository articleRepository)
        {
            this.articleRepository = articleRepository;
        }

        public Article GetArticleById(String title)
        {
            return articleRepository.GetArticleById(title);
        }

        public List<Article> GetAllArticles()
        {
            return articleRepository.GetAllArticles();
        }

        public object Add(object obj)
        {
            return articleRepository.Add(obj);
        }

        public object Edit(object obj)
        {
            return articleRepository.Edit(obj);
        }

        public object Delete(object obj)
        {
            return articleRepository.Delete(obj);
        }
    }
}