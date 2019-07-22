<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Post;
use App\Category;
use App\Tag;

class HomepageController extends Controller
{
    public function index()
    {
        $lsPost = Post::orderBy('created_at', 'desc')->paginate(4);
        $lsCate = Category::all();
        return view('welcome')->with(['lsPost'=> $lsPost]);
    }

    public function view_post($id)
    {
        $post = Post::find($id);
        return view('view_post') -> with(['post' => $post]);
    }
    public function view_post_tag($id)
    {
        $tag = Tag::find($id);
        $lsPost = $tag -> posts() -> paginate(2);
        // dd($lsTag);
        return view('view_post_tag') -> with(['tag' => $tag, 'lsPost'=>$lsPost]);
    }
    public function view_post_cate($id)
    {
        $cate = Category::find($id);
        $lsPost = $cate -> posts() -> paginate(2);
        // dd($lsTag);
        return view('view_post_cate') -> with(['cate' => $cate, 'lsPost'=>$lsPost]);
    }
}
