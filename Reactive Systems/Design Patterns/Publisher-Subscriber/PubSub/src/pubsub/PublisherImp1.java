/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pubsub;

import java.util.HashMap;
import java.util.List;

/**
 *
 * @author k00220137
 */
public class PublisherImp1 implements Publisher {
    String firstPublisher;
    
    public PublisherImp1(String firstPublisher)
    {
   
        this.firstPublisher = firstPublisher;
    }
    
    @Override
    public void publish(Topic topic, String message) {
        System.out.println("Submitting message "+message+" with topic "+topic+" to topic manager");
    }
    
}
