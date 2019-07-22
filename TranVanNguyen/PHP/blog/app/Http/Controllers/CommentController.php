<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Comment;

class CommentController extends Controller
{
    public function post_comment(Request $request, $id)
    {
    //     $msg = [
    //         'name.required' => 'A name is required',
    //         'email.required' => 'Email is required'
    //     ];
    //     $request->validate([
    //         'name' => 'required|max:255|min:3'
    //       ], $msg);

      $name = $request->input("name");
      $email = $request-> input("email");
      $content = $request-> input("content");


      $new_comment = new Comment();
      $new_comment->name = $name;
      $new_comment->email = $email;
      $new_comment->content = $content;
      $new_comment -> status = 1;
      $new_comment -> post_id = $id;


      $new_comment->save();
      
      return redirect()->back();
    }
    public function comment()
    {
      $lsComment = Comment::orderBy('created_at','desc')->paginate(10);
      return view("comment.list")-> with(['lsComment'=> $lsComment]);
    }
    public function change_comment_status_ajax(Request $request)
    {
      $comment_id = $request -> comment_id;
      $comment_status = $request -> comment_status;

      $comment = Comment::find($comment_id);
      $comment -> status = $comment_status;
      $comment -> save();

      return response()->json([
        'success' => 'Thành công',
      ]);
    }
    public function post_comment_ajax($id, Request $request) {
      $comment = new Comment();
      $comment->post_id = $id;
      $comment->name = $request->name;
      $comment->email = $request->email;
      $comment->content = $request->content;
      $comment->status = 1;
      $comment->save();
      return response()->json([
          'success' => 'Thành công',
          'created_at' => $comment->created_at
      ]);
    }
}
