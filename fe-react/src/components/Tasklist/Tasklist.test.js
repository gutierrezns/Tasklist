import React from 'react';
import { render, screen } from '@testing-library/react';
import '@testing-library/jest-dom/extend-expect';
import Tasklist from './Tasklist';

describe('<Tasklist />', () => {
  test('it should mount', () => {
    render(<Tasklist />);
    
    const tasklist = screen.getByTestId('Tasklist');

    expect(tasklist).toBeInTheDocument();
  });
});