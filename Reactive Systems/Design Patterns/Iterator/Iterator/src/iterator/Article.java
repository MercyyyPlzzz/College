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
public class Article {
    String topic;
    String headline;
    String body;
    String author;

    
    /**
* Another constructor for class Time1
* @param topic  <Sport, politics, entertainment, health, etc>
* @param headline  <Short sentance that describes story>
* @param body  <full article for the story>
* @param author  <authors name>
*/
    public Article(String topic, String headline, String body, String author) {
        this.topic = topic;
        this.headline = headline;
        this.body = body;
        this.author = author;
    }

    public String getTopic() {
        return topic;
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
