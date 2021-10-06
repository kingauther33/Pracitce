import React from 'react';
import logo from './logo.svg';
import './App.css';
import { BasicTable } from './Components/BasicTable';
import { SortingTable } from './Components/SortingTable';
import { FilteringTable } from './Components/FilteringTable';
import { PaginationTable } from './Components/PaginationTable';
import { RowSelection } from './Components/RowSelection';
import { ColumnOrder } from './Components/ColumnOrder';
import { ColumnHiding } from './Components/ColumnHiding';
import { StickyTable } from './Components/StickyTable';

function App() {
	return (
		<div className="App">
			<StickyTable />
		</div>
	);
}

export default App;
