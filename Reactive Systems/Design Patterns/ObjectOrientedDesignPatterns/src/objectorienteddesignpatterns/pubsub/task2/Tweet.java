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
public class Tweet {
 private String created_at;
 private String text;
 User UserObject;

    public Tweet(String created_at, String text, User UserObject) {
        this.created_at = created_at;
        this.text = text;
        this.UserObject = UserObject;
    }

 // Getter Methods 

 public String getCreated_at() {
  return created_at;
 }

 public String getText() {
  return text;
 }

 public User getUser() {
  return UserObject;
 }




}
