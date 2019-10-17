/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package oo_design_patterns_ca.pubsub2;



/**
 *
 * @author James
 */
public interface NotificationServiceProvider {
    
    public void notify(Topic t, String m);
    
    public void registerSubscriber(Subscriber s, Topic t);
    
    public void unRegisterSubscriber(Subscriber s, Topic t);
    
}
