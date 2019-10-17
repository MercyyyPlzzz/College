/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pubsub;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

/**
 *
 * @author k00220137
 */
enum Topic{
    TOPIC1,
    TOPIC2,
    TOPIC3,
}
public class NotificationServiceImp1 implements NotificationServiceProvider{
    private HashMap<Topic, List<Subscriber>> subscriberLists;
    
    private static NotificationServiceImp1 notificationService;
    
    //Singleton
    public static NotificationServiceImp1 getInstance()
    {
        if(notificationService == null)
        {
            notificationService = new NotificationServiceImp1();
        }
        return notificationService;
    }
    
    private NotificationServiceImp1()
    {
        this.subscriberLists = new HashMap<>();
    }
    
    public void notify(Topic t,String m)
    {
        List<Subscriber> subs = subscriberLists.get(t);
        System.out.println("Topic Manger - Sending message"+m+" with topic "+t+"to "+subs+" subscribers");
        for(Subscriber s:subs)
        {
            s.notify();
        }
    }
    
    public void registerSubscriber(Subscriber s,Topic t)
    {
        if(subscriberLists.get(t)==null)
        {
            subscriberLists.put(t,new ArrayList<>());
        }
        subscriberLists.get(t).add(s);
        
        System.out.println("Topic Manager - Now Have "+subscriberLists.get(t).size());
    }
    
    public void unRegisterSubscriber(Subscriber s,Topic t)
    {
        if(subscriberLists.get(t)!=null)
        {
            subscriberLists.get(t).remove(s);
        }
    }
    
}
    
