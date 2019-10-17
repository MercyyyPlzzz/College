/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pubsub;

/**
 *
 * @author k00220137
 */
public class PubSub {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Subscriber sub1 = new SubscriberImp1("First Subscriber");
        Subscriber sub2 = new SubscriberImp1("Second Subscriber");
        Subscriber sub3 = new SubscriberImp1 ("Third Subscriber");
        
        NotificationServiceImp1.getInstance().registerSubscriber(sub1, Topic.TOPIC1);
        NotificationServiceImp1.getInstance().registerSubscriber(sub2, Topic.TOPIC2);
        NotificationServiceImp1.getInstance().registerSubscriber(sub3, Topic.TOPIC3);
        
        Publisher pub1 = new PublisherImp1("FirstPublisher");
        
        pub1.publish(Topic.TOPIC1,"first message");
        pub1.publish(Topic.TOPIC2,"something different");
        pub1.publish(Topic.TOPIC3,"More more");
        
        NotificationServiceImp1.getInstance().registerSubscriber(sub1,Topic.TOPIC2);
        
        pub1.publish(Topic.TOPIC2,"something different again");
    }
    
}
