<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Comment;
class CommentController extends Controller
{
    public function post_comment($id, Request $request) {
      $comment = new Comment();
      $comment->post_id = $id;
      $comment->name = $request->name;
      $comment->email = $request->email;
      $comment->content = $request->message;
      $comment->status = 1;
      $comment->save();
      return redirect()->back();
    }

    public function post_comment_ajax($id, Request $request) {
      $comment = new Comment();
      $comment->post_id = $id;
      $comment->name = $request->name;
      $comment->email = $request->email;
      $comment->content = $request->message;
      $comment->status = 1;
      $comment->save();

      return response()->json([
          'success' => 'Thành công',
          'created_at' => $comment->created_at
      ]);
    }
}
