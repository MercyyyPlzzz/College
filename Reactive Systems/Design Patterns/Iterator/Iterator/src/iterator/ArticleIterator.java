/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.lit.reactivesystems.objectorienteddesignpatterns.iterator;

/**
 *
 * @author James
 */
public class ArticleIterator implements Iterator{

    private Article[] articles;
    private int position;
     
    public ArticleIterator(Article[] articles)
    {
        this.articles = articles;
        position = 0;
    }

    @Override
    public Article next() {
        return articles[position++];
    }
 
    @Override
    public boolean hasNext() {
        if(position >= articles.length)
            return false;
        return true;
    }
    
}
