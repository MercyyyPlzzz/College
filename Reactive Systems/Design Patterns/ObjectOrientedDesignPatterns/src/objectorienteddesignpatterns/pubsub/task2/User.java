/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package objectorienteddesignpatterns.pubsub.task2;

/**
 *
 * @author James
 */
public class User {
 private final String id_str;
 private final String name;
 private final String screen_name;
 private final String location;

    public User(String id_str, String name, String screen_name, String location) {
        this.id_str = id_str;
        this.name = name;
        this.screen_name = screen_name;
        this.location = location;
    }
 
    public String getId_str() {
        return id_str;
    }

    public String getName() {
        return name;
    }

    public String getScreen_name() {
        return screen_name;
    }

    public String getLocation() {
        return location;
    }

}
