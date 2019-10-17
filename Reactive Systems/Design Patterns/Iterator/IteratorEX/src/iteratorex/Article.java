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
//Object Creater for ConcreteAggregate
public class Article {
    String topic;
    String headline;
    String body;
    String author;

    public String getTopic() {
        return topic;
    }

    public Article(String topic, String headline, String body, String author) {
        this.topic = topic;
        this.headline = headline;
        this.body = body;
        this.author = author;
    }

    public String getHeadline() {
        return headline;
    }

    public String getBody() {
        return body;
    }

    public String getAuthor() {
        return author;
    }
    
    
}
