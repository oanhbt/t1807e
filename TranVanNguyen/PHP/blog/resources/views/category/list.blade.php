@extends('layouts.app')

@section('content')
<h2>Category managements</h2>

<div class="flash-message">
@foreach (['danger', 'warning', 'success', 'info'] as $msg)        	@if(Session::has($msg))
		<p class="alert alert-{{ $msg }}">{{ Session::get($msg) }} 		</p>
	@endif
 @endforeach
</div> <!-- end .flash-message -->



<a href="category/create" class="btn btn-info my-3">New Category</a>

<table class="table">
  <tr>
    <th>No</th>
    <th>Name</th>
    <th>View</th>
    <th>Edit</th>
    <th>Delete</th>
  </tr>
@foreach($lsCate as $i => $cate)
  <tr>
    <td>{{$i + 1}}</td>
    <td>{{$cate->name}}</td>
    <td><a href="{{route('category.show', $cate->id)}}">View</a></td>
    <td><a href="{{route('category.edit', $cate->id)}}">update</a></td>
    <td>
      <form action="{{route('category.destroy', $cate->id)}}"
					method="POST"
        	onsubmit="return confirm('Sure ?')">
        	@csrf
        	<input type="hidden" name="_method" value="DELETE" />
        	<input type="submit" value="Delete" />
      </form>
    </td>
  </tr>
@endforeach
</table>
@endsection
