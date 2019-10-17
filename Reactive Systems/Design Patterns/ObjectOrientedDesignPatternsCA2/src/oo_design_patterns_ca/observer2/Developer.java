/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package oo_design_patterns_ca.observer2;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author k00220137
 */

//Subject Imp
public class Developer implements Observer{
List<String> updatesList;

    Developer(String email) {
        updatesList=new ArrayList();
        updatesList.add(email);
    }

    @Override
    public void update(String update) {
        System.out.println(" received update: Java : "+update);
    }
   
}
