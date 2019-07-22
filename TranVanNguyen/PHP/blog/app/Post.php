<?php

namespace App;

use Illuminate\Database\Eloquent\Model;


class Post extends Model
{

    public function User()
    {
       return $this->belongsTo('App\User');
    }
    public function categories()
    {
        return $this->belongsToMany('App\Category','post__categories');
    }
    public function tags()
    {
        return $this->belongsToMany('App\Tag','post__tags');
    }
    public function comments()
    {
        return $this->hasMany('App\Comment');
    }
}
