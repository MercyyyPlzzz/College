/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package oo_design_patterns_ca.pubsub2;

/**
 *
 * @author k00220137
 */
public class ConcertPromoter implements Publisher {
String firstPublisher;

public ConcertPromoter (String firstPublisher)
{
    this.firstPublisher=firstPublisher;
}
    @Override
    public void publish(Topic sensor, String message) {
        System.out.println(sensor+" : "+message);
    }
    
}
