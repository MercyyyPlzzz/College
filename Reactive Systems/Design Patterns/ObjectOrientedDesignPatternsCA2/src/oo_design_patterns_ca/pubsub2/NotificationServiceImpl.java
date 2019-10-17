/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package oo_design_patterns_ca.pubsub2;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;


/**
 *
 * @author James
 */
public class NotificationServiceImpl implements NotificationServiceProvider{
private HashMap<Topic,List<Subscriber>> subscriberLists;

private static NotificationServiceImpl notificationService;

public static NotificationServiceImpl getInstance()
{
    if(notificationService == null)
    {
        notificationService = new NotificationServiceImpl();
    }
    return notificationService;
}

private NotificationServiceImpl()
{
    this.subscriberLists=new HashMap<>();
}
    @Override
    public void notify(Topic t, String m) {
       List<Subscriber> subs=subscriberLists.get(t);
        for(Subscriber s:subs)
        {
            s.notify();
        }
    }

    @Override
    public void registerSubscriber(Subscriber s, Topic t) {
if(subscriberLists.get(t)==null)
{    
subscriberLists.put(t,new ArrayList<>());
    }
subscriberLists.get(t).add(s);
    }

    @Override
    public void unRegisterSubscriber(Subscriber s, Topic t) {
if(subscriberLists.get(t)!=null)
{
subscriberLists.get(t).remove(s);    
}}
   
}
