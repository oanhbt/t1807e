<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Post;
use App\Category;
use Illuminate\Support\Facades\Route;

class HomePageController extends Controller
{
    public function index() {
        $lsPost = Post::orderBy('created_at', 'desc')->paginate(4);
        return view('welcome')->with(['lsPost' => $lsPost]);
    }

    public function view_post($id) {
      $post = Post::find($id);
      return view("view_post")->with(['post' => $post]);
    }

    public function view_post1($id) {
      $post = Post::find($id);
      return view("view_post")->with(['post' => $post]);
    }

    public function view_category($id) {
        $category = Category::find($id);
        $lsPost = $category->posts()->paginate(1);
        return view('view_category')->with(['lsPost' => $lsPost, 'category' => $category ]);
    }

    public function view_tag($id) {
        $tag = Tag::find($id);
        $lsPost = $tag->post;
        return view('view_tag')->with(['lsPost' => $lsPost]);
    }


}
