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
public class SubscriberImp1 implements Subscriber{
String id;
    public SubscriberImp1(String id)
    {
        this.id = id;
    }
    
    @Override
    public void notify(String message) {
        System.out.println("Subscriber "+id+" recieved message : "+message);
    }
    
}
