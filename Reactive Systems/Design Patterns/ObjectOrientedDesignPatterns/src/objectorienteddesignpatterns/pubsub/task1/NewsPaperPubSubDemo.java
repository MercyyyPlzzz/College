/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package objectorienteddesignpatterns.pubsub.task1;


/**
 *
 * @author James
 */
public class NewsPaperPubSubDemo {
    
        public static void main(String args[]) {    
            
        /*Subscriber sub1 = new ReaderSubImpl("FirstSubscriber");
        Subscriber sub2 = new ArchiverSubImpl("SecondSubscriber");
        Subscriber sub3 = new ReaderSubImpl("ThirdSubscriber");
        
        ArticleNotificationServiceImpl articleDistributer = ArticleNotificationServiceImpl.getInstance();
        
        articleDistributer.registerSubscriber(sub1, Topic.CURRENT_AFFAIRS);
        articleDistributer.registerSubscriber(sub2, Topic.CURRENT_AFFAIRS);
        articleDistributer.registerSubscriber(sub3, Topic.SPORT);
        
        
        Article henshawOut= new Article(Topic.SPORT, "Henshaw out injured", "Henshaw pulled his hamstring yada yada .....", "L. Fitzgreald");
        Article henshawIn= new Article(Topic.SPORT, "Henshaw is not injured badly ", "Henshaw pulled his hamstring but not too bad yada yada .....", "R. O'Coonr");
        Article brexitIsStillAThing = new Article(Topic.CURRENT_AFFAIRS, "BoJo Visits Juncker", "Boris is talking to Juncker and there will be lots of talk about it later ...", "M. Cooper");
        Article trumpDidSoemthing = new Article(Topic.CURRENT_AFFAIRS, "Trump has Twitter Account", "Trump tweeted something and there will be lots of talk about it later ...", "F. News");
        Article someActorSaidSomethingAboutIreland = new Article(Topic.ENTERTAINMENT, "Something Something Guinness is Great", "Ireland gets a mention during the promotion of a movie, you should watch it ...", "D. Fanning");
        Article grahamNortonVideoClip = new Article(Topic.ENTERTAINMENT, "Something Something Graham Norto", "Graham Norton's script writers and researchers are on the ball - actor was self deprecating ...", "B. rainless");
    
        NewsPaper irishTimes = new NewsPaper("Irish Times");
        NewsPaper irishIndependent = new NewsPaper("Irish Indo");
            
        irishTimes.publish(henshawOut.getTopic(), henshawOut );
        irishTimes.publish(Topic.ENTERTAINMENT, someActorSaidSomethingAboutIreland);
        irishIndependent.publish(henshawIn.getTopic(), henshawIn );
        
        articleDistributer.registerSubscriber(sub1, Topic.ENTERTAINMENT);
        
        irishIndependent.publish(Topic.ENTERTAINMENT, grahamNortonVideoClip);
        irishTimes.publish(brexitIsStillAThing.getTopic(), brexitIsStillAThing);
        irishTimes.publish(trumpDidSoemthing.getTopic(), trumpDidSoemthing);*/
    
    }
    
}
