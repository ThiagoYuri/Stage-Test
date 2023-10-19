/* eslint-disable */
import React from 'react';
import './ListButton.css'
const List = ({ datas }) => {
    //console.log(datas)

    return (

        <div>
            <ol  role="list">
                {
                    datas.map(data =>
                        <li key={data.id}>
                            <h3>{data.nome}</h3>
                            <p>Descrição: Lorem ipsum  consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Adipiscing diam donec adipiscing tristique risus.</p>
                        </li>
                    )
                }
            </ol>

        </div>
    );
}

export { List }