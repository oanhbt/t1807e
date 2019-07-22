<?php

namespace App;

use Illuminate\Database\Eloquent\Model;
use Illuminate\Database\Eloquent\SoftDeletes;

class Category extends Model
{
  use SoftDeletes;
  protected $date = ['deleted_at'];
  public function posts()
  {
      return $this->belongsToMany('App\Post','post__categories');
  }
}
