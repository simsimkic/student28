using System;
using Service.UserService;
using Model.UserModel;
using System.Collections.Generic;

namespace Controller.UserController
{
    public class ArticleController : IArticleController
    {
        private static ArticleController instance { get; set; }
        private ArticleService articleService { get; set; }

        public static ArticleController GetInstance(ArticleService articleService)
        {
            if(instance == null)
            {
                instance = new ArticleController(articleService);
            }
            return instance;
        }

        private ArticleController(ArticleService articleService)
        {
            this.articleService = articleService;
        }

        public Article GetArticleById(String title)
        {
            return articleService.GetArticleById(title);
        }

        public List<Article> GetAllArticles()
        {
            return articleService.GetAllArticles();
        }

        public object Add(object obj)
        {
            return articleService.Add(obj);
        }

        public object Edit(object obj)
        {
            return articleService.Edit(obj);
        }

        public object Delete(object obj)
        {
            return articleService.Delete(obj);
        }
    }
}