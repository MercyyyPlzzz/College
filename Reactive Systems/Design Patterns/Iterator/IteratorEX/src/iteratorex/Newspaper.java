/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package iteratorex;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author k00220137
 */
//ConcreteAggregate
public class Newspaper implements Aggregate {

    private Article[] articles;

    public Newspaper(Article[] articles) {
        this.articles = articles;
    }
    
    public Iterator<Article> iterator()
    {
        return new ArticleIterator(articles,0);
    }
    
    public Article[] addActicle(Article newArticle)
    {
        List<Article> articlesList=new ArrayList<>();
        articlesList.add(newArticle);
        articles=articlesList.toArray(new Article[articlesList.size()]);
        return articles;
    }
    
    
}
