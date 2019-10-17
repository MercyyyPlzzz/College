/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package observerex;

/**
 *
 * @author k00220137
 */
public class ConcObs1 implements Observer {
    @Override
    public void update(String update) {
        System.out.println("Observer 1 received the update : "+update.toUpperCase());
    }  
}
