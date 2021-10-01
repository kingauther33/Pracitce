import React, { useMemo } from 'react';
import { useTable } from 'react-table';
import MOCK_DATA from './MOCK_DATA.json';
import { COLUMNS } from './columns';

export const BasicTable = () => {
	const columns = useMemo(() => COLUMNS, []);
	const data = useMemo(() => MOCK_DATA, []);

	useTable({
		columns: COLUMNS,
		data: MOCK_DATA,
	});

	return <div></div>;
};
