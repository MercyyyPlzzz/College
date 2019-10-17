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
public class PubSubDemo {
    
        public static void main(String args[]) {    
            
        Subscriber sub1 = new User("num1InDaCharts@wan.ie");
        Subscriber sub2 = new User("iLuvMuzic2@wfell.ws");
        Subscriber sub3 = new User("chooooon@lit.ie");
        
        
        NotificationServiceImpl.getInstance().registerSubscriber(sub1, Topic.FREYA_RIDINGS);
        NotificationServiceImpl.getInstance().registerSubscriber(sub2, Topic.SAM_SMITH);
        NotificationServiceImpl.getInstance().registerSubscriber(sub3, Topic.LEWIS_CAPALDI);
        
        ConcertPromoter mcd = new ConcertPromoter("MCD");
        ConcertPromoter tkts = new ConcertPromoter("Tickets.ie");
        ConcertPromoter indy = new ConcertPromoter("IndyRecords");
            
        mcd.publish(Topic.FREYA_RIDINGS,  "is playing in Cork" );
        tkts.publish(Topic.LEWIS_CAPALDI,  "is playing in the Point" );
        indy.publish(Topic.SAM_SMITH,  "is playing at Electric Picnic" );
        mcd.publish(Topic.FREYA_RIDINGS,  "has cancelled gig in Cork" );

        NotificationServiceImpl.getInstance().registerSubscriber(sub1, Topic.SAM_SMITH);
        
        mcd.publish(Topic.SAM_SMITH,  "is playing a second night in Dublin" );
  
    }
    
}





