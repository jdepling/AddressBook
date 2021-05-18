import React, { useState, useEffect} from 'react';

export function Home() {
    const [viewId, setViewId] = useState(1)
    return (<GetAddresses key={viewId} startAgain={() => setViewId(viewId + 1)}/>);
}

const Delete = async (id, startAgain) => {
    const other_params = {
        headers: { "content-type": "application/json; charset=UTF-8" },
        method: "DELETE",
        mode: "cors"
    };
    var response = await fetch('addressbook/' + id, other_params);
    var removedRecord = await response.json();

    alert(`Record removed for: ${removedRecord.firstName} ${removedRecord.lastName}`);

    startAgain(); // calls the inline function on the startAgain prop in the GetAddresses component in the Home function
}


function GetAddresses(props) {
    const [data, setData] = useState([]);

    useEffect(() => {
        const fetchData = async () => {
            var response = await fetch('addressbook');
            var info = await response.json();
            setData(info);
        }
        fetchData();
    }, []);

    return (
        <table className='table table-striped' aria-labelledby="tabelLabel">
            <thead>
                <tr>
                    <td>First Name</td>
                    <td>Last Name</td>
                    <td>Street Address</td>
                    <td>City</td>
                    <td>State</td>
                    <td>Zip Code</td>
                </tr>
            </thead>
            <tbody>
                {data.map((info) =>
                    <tr>
                        <td key={info.id}><button onClick={() => Delete(info.id, props.startAgain)} style={{ color: "red", fontSize: 10, borderStyle: "thin" }}>x</button>{info.firstName}</td>
                        <td>{info.lastName}</td>
                        <td>{info.streetAddress}</td>
                        <td>{info.city}</td>
                        <td>{info.state}</td>
                        <td>{info.zipCode}</td>
                    </tr>
                    )}
            </tbody>
        </table>
        );
}
