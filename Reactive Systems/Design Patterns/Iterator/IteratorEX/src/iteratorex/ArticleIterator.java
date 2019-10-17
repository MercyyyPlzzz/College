/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package iteratorex;

/**
 *
 * @author k00220137
 */

//ConcreteIterator
public class ArticleIterator implements Iterator {

    private Article[] articles;
    private int position;

    public ArticleIterator(Article[] articles, int position) {
        this.articles = articles;
        position =0;
    }
    
    
    @Override
    public Object next() {
        return articles[position++];
    }

    @Override
    public boolean hasNext() {
        if(position >= articles.length)
            return false;
        return true;
    }
    
    
 
    
}
