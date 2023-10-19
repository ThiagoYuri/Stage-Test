/* eslint-disable */
import React from 'react';
import { List } from '../List/List';

const CreateList = ({ columns, datas }) => {

    return (
        <List columns={columns} datas={datas}></List>
    );

}

export { CreateList }