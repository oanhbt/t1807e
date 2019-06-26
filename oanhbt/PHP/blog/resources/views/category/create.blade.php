@extends('layouts.app')

@section('content')
<div class="container">
<h2>Create new category:</h2>

<form method="POST" action="{{route('category.store')}}">
  @csrf
  <div class="form-group">
    <label for="name">Name:</label>
    <input type="text" class="form-control" name="name">
  </div>

  <input type="Submit" value="Create" class="btn btn-info my-3" />
</form>
</div>
@endsection
