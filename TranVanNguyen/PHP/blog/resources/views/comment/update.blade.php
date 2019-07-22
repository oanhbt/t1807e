@extends('layouts.app')

@section('content')
<div class="container">
<h2>Update tag:</h2>

<form method="POST" action="{{route('tag.update', $tag->id)}}">
  @csrf
  @method('PUT')
  <div class="form-group">
    <label for="name">Name:</label>
    <input type="text" class="form-control" name="name" value="{{$tag->name}}">
  </div>

  <a href="{{route('tag.index')}}" class="btn btn-info my-3">Back</a>
  <input type="Submit" value="update" class="btn btn-info my-3" />

</form>
</div>
@endsection
