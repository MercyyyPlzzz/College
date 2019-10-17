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
public class User implements Subscriber{
String id;
public User(String id)
{
    this.id=id;
}
    @Override
    public void notify(String message) {
        System.out.println(id+" received update announces "+message+" : "+message);
    }
    
}
