<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Category;
use App\Tag;
use App\Post;
use App\Post_Category;
use App\Post_Tag;

class PostController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $lsPost = Post::all();
        return view("post.list")->with(["lsPost" => $lsPost]);
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        $lsCate = Category::all();
        $lsTag = Tag::all();
        return view("post.create")
          ->with(['lsCate' => $lsCate, 'lsTag' => $lsTag]);
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
      //dd($request->category);
      // $msg = [
      //     'title.required' => 'A name is required'
      // ];
      // $request->validate([
      //     'title' => 'required|max:255|min:3'
      // ], $msg);

      $cover = $request->cover;
      if( $cover != null) {
        $image_name = time()."_".$cover->getClientOriginalName();
        if($cover->isValid()) {
          $cover->move('images', $image_name );
        }
        $path = "images/".$image_name;
      } else {
        $path = "";
      }
      $user = auth()->user();

      $post = new Post();
      $post->tile = $request->title;
      $post->cover = $path;
      $post->user_id = $user->id;
      $post->content = $request->content;
      $post->save();

      $lsSelectedCate = $request->category;
      $lsSelectedTag = $request->tag;

      if($lsSelectedCate != null && count($lsSelectedCate) > 0) {
        foreach ($lsSelectedCate as $selecteCate) {
          $post_Category = new Post_Category();
          $post_Category->category_id = $selecteCate;
          $post_Category->post_id = $post->id;
          $post_Category->save();
        }
      }

      if($lsSelectedTag != null && count($lsSelectedTag) > 0) {
        foreach ($lsSelectedTag as $selecteTag) {
          $post_Tag = new Post_Tag();
          $post_Tag->tag_id = $selecteTag;
          $post_Tag->post_id = $post->id;
          $post_Tag->save();
        }
      }

      $request->session()->flash('success', 'Post was successful!');
      return redirect()->route("post.index");

    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        $post = Post::find($id);
        return view("post.view")
          ->with(['post' => $post]);
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, $id)
    {
        //
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        //
    }
}
