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
public class IteratorImplementationExample {
    
    
    
    
    
    public static void main(String[] args){
    Article henshawOut= new Article("Sport", "Henshaw out injured", "Henshaw pulled his hamstring yada yada .....", "L. Fitzgreald");
    Article henshawIn= new Article("Sport", "Henshaw is not injured badly ", "Henshaw pulled his hamstring but not too bad yada yada .....", "R. O'Coonr");
    Article dubsWinEverything= new Article("Sport", "Dublin win Everything ", "They have lots of money and 1/3 of the population yada yada .....", "J. Brolly");
    Article brexitIsStillAThing = new Article("Politics", "BoJo Visits Juncker", "Boris is talking to Juncker and there will be lots of talk about it later ...", "M. Cooper");
    Article trumpDidSoemthing = new Article("Politics", "Trump has Twitter Account", "Trump tweeted something and there will be lots of talk about it later ...", "F. News");
    Article amazonOnFire = new Article("Politics", "The Amazon is on Fire", "People are burning the Amazon on purpose and there will be lots of talk about it later ...", "B. Dobson");
    Article theKardashiansAreStillAThing = new Article("Entertainment", "Something Something Kardashians", "People are burning the Amazon on purpose and there will be lots of talk about the Kardashians ...", "N. Onsense");
    Article someActorSaidSomethingAboutIreland = new Article("Entertainment", "Something Something Guinness is Great", "Ireland gets a mention during the promotion of a movie, you should watch it ...", "D. Fanning");
    Article grahamNortonVideoClip = new Article("Entertainment", "Something Something Graham Norto", "Graham Norton's script writers and researchers are on the ball - actor was self deprecating ...", "B. rainless");
    
        
        
        Article[] todaysArticles = new Article[9];
        
        todaysArticles[0]= henshawOut;
        todaysArticles[1]=  henshawIn;
        todaysArticles[2]=  dubsWinEverything;
        todaysArticles[3]=  brexitIsStillAThing;
        todaysArticles[4]=  trumpDidSoemthing;
        todaysArticles[5]=  amazonOnFire;
        todaysArticles[6]=  theKardashiansAreStillAThing;
        todaysArticles[7]=  someActorSaidSomethingAboutIreland;
        todaysArticles[8]=  grahamNortonVideoClip;
    
        
        NewsPaper todaysNews =new NewsPaper (todaysArticles);
        
        Iterator<Article>artIterator = todaysNews.articleIterator();
        
        while(artIterator.hasNext()){
            Article nextArticle = artIterator.next();
            System.out.println("Headline : "+nextArticle.headline);
        }
    }
    
  
    
    
    //NewsPaper
    
            
    
    
}
