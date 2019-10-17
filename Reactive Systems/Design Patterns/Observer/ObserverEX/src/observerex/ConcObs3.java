/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package observerex;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 *
 * @author k00220137
 */
public class ConcObs3 implements Observer{
    List<String> updateList;
    Scanner in;
    public ConcObs3()
    {
        updateList=new ArrayList();
        in = new Scanner(System.in);
    }
    public List<String> getUpdateList() {
        return updateList;
    }
    
    @Override
    public void update(String update){
        updateList.add(update);
    }
}
