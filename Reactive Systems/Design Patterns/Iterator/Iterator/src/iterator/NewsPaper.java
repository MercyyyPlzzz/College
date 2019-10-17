/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.lit.reactivesystems.objectorienteddesignpatterns.iterator;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author James
 */
public class NewsPaper{
    private Article[] articles;
     
    public NewsPaper(Article[] articles)
    {
        this.articles =  articles;
    }
     
    
    public Iterator<Article> articleIterator() {
        return new ArticleIterator(articles);
    }
    
    public Article[] addArticle(Article newArticle){
        List<Article> articlesList = new ArrayList<>();
        articlesList.add(newArticle);
        articles = articlesList.toArray(new Article[articlesList.size()]);
        return articles;
    }
}